
namespace FoodDeliverySystem
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Restaurant Data Management ===");
                Console.WriteLine("1. Create and Parse Restaurant Data (XML)");
                Console.WriteLine("2. Create and Parse Menu Items (CSV)");
                Console.WriteLine("3. Create and Read Restaurant Data (Excel)");
                Console.WriteLine("4. Create and Parse Restaurant Reviews (JSON)");
                Console.WriteLine("5. Fetch Restaurants using REST API");
                Console.WriteLine("6. Fetch ServiceNow Incident Data");
                Console.WriteLine("7. Upload/Download Restaurant Documents (Box API)");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option (1-8): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        XmlHandler.CreateRestaurantXML("restaurants.xml");
                        XmlHandler.ParseRestaurantXML("restaurants.xml");
                        break;
                    case "2":
                        CSVHandler.CreateRestaurantMenuCSV("menu.csv");
                        CSVHandler.ParseRestaurantMenuCSV("menu.csv");
                        break;
                    case "3":
                        ExcelHandler.CreateRestaurantExcel("restaurants.xlsx");
                        ExcelHandler.ReadRestaurantExcel("restaurants.xlsx");
                        break;
                    case "4":
                        JSONHandler.CreateReviewJSON("reviews.json");
                        JSONHandler.ParseReviewJSON("reviews.json");
                        break;
                    case "5":
                        await GetRestaurantsAPI();
                        break;
                    case "6":
                        // await ServiceNowApiHandler.FetchServiceNowIncidents();
                        break;
                    case "7":
                        //await HandleBoxAPI();
                        break;
                    case "8":
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }
        async Task GetRestaurantsAPI()
        {
            ShowDelayedMessage("fetching data from API.");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7139/");

                var response = await client.GetAsync("api/Restaurants/GetAll");

                if (response.IsSuccessStatusCode)
                {
                    var restaurants = await response.Content.ReadFromJsonAsync<List<Restaurant>>();

                    Console.WriteLine("\n-------------------------------------");
                    foreach (var restaurant in restaurants)
                    {
                        Console.WriteLine($"Restaurant Name: {restaurant.Name},\t Address: {restaurant.Address},\t Rating: {restaurant.Rating}");
                    }
                }
                else
                {
                    Console.WriteLine("Error retrieving data.");
                }
            }
        }
        /*static async Task HandleBoxAPI()
        {
            BoxApiHandler.InitializeBoxClient();
            Console.WriteLine("1. Upload File");
            Console.WriteLine("2. Download File");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Enter folder ID: ");
                string folderId = Console.ReadLine();
                Console.Write("Enter file path to upload: ");
                string filePath = Console.ReadLine();
                await BoxApiHandler.UploadFileToBox(folderId, filePath);
            }
            else if (option == "2")
            {
                Console.Write("Enter file ID: ");
                string fileId = Console.ReadLine();
                Console.Write("Enter save path: ");
                string savePath = Console.ReadLine();
                await BoxApiHandler.DownloadFileFromBox(fileId, savePath);
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }*/
    }
}