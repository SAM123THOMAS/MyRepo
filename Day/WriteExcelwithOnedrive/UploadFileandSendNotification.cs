using Azure.Identity;
using Microsoft.Graph;

namespace OneDriveUpload
{
    internal class Program
    {
        private static readonly string tenantId = "3e1c602f-7880-45e7-b38e-b87855ef174d";
        private static readonly string clientId = "0008e470-c01b-441d-81b2-5a69aaf2b8c7";
        private static readonly string clientSecret = "LeR8Q~m0rrUDir4LXei58~7l9b9eqhboDKC4cdkM";
        private static readonly string userEmail = "Sam@ervikashverma.onmicrosoft.com";
        private static readonly string filePath = "TestingFile.txt";
        private static readonly string recipentEmail = "Sangeetha@ervikashverma.onmicrosoft.com";
        static async Task Main(string[] args)
        {
            var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var client = new GraphServiceClient(credential);
            var uplaodedFile = await UploadFileToDrive(client, filePath);

            var credentails = new InteractiveBrowserCredential(new InteractiveBrowserCredentialOptions
            {
                ClientId = clientId,
                TenantId = tenantId,
            });

            var clientTeam = new GraphServiceClient(credentails);

            await SendMessageToUser(clientTeam, recipentEmail, $"Hello Arjun, File pushed successfully!! ID   Thanks Sam");


        }

        private static async Task<DriveItem> UploadFileToDrive(GraphServiceClient client, string filePath)
        {
            var fileName = Path.GetFileName(filePath);
            using (var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                var uploadSession = await client.Users[userEmail].Drive.Root.ItemWithPath(fileName).
                    CreateUploadSession().Request().PostAsync();

                var maxChunckSize = 320 * 1024;//320KB
                var chuckUploadProvider = new ChunkedUploadProvider(uploadSession, client, fileStream, maxChunckSize);
                var uploadedItem = await chuckUploadProvider.UploadAsync();
                Console.WriteLine($"File uploaded successfully ID: {uploadedItem.Id}");

                 return uploadedItem;
            }
        }


        public static async Task SendMessageToUser(GraphServiceClient client, string recipentEmail, string messageContent)
        {

            var user = await client.Users[recipentEmail].Request().GetAsync();
            var chat = await CreateChatWithUser(client, user.Id);
            var chatMessage = new ChatMessage
            {
                Body = new ItemBody
                {
                    Content = messageContent
                }
            };
            await client.Chats[chat.Id].Messages.Request().AddAsync(chatMessage);
            Console.WriteLine("Message sent successfully");

        }

        public static async Task<Chat> CreateChatWithUser(GraphServiceClient client, string userId)
        {
            var loggedInUser = await client.Me.Request().GetAsync();
            var chat = new Chat
            {
                ChatType = ChatType.OneOnOne,
                Members = new ChatMembersCollectionPage()
            };

            var loggedInuserMember = new AadUserConversationMember
            {
                Roles = new List<string> { "owner" },
                AdditionalData = new Dictionary<string, object>
                {
                    {"user@odata.bind",$"https://graph.microsoft.com/v1.0/users/{loggedInUser.Id}" }
                }
            };
            chat.Members.Add(loggedInuserMember);



            var recipientuserMember = new AadUserConversationMember
            {
                Roles = new List<string> { "owner" },
                AdditionalData = new Dictionary<string, object>
                {
                    {"user@odata.bind",$"https://graph.microsoft.com/v1.0/users/{userId}" }
                }
            };
            chat.Members.Add(recipientuserMember);
            var newChat = await client.Chats.Request().AddAsync(chat);
            return newChat;
        }
    }
}