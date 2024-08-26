using Box.V2.Config;
using Box.V2.JWTAuth;
using Box.V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoxAPIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<List<BoxItem>> Get()
        {
            string clientId = "4m8ccnmh2oy629pqv52hlt710nfpa586";
            string clientSecret = "idiyrJaC1EmRI9driFUhEs7ww93TGiMM";
            string devToken = "PKbZZmT6HfjMCwjvIDfdCcfZs9X2mrzs";

            var boxConfig = new BoxConfig(clientId, clientSecret, new Uri("http://localhost"));
            var boxJWTAuth = new BoxJWTAuth(boxConfig);

            var boxClient = boxJWTAuth.AdminClient(devToken);


            var user = await boxClient.UsersManager.GetCurrentUserInformationAsync();

            var items = await boxClient.FoldersManager.GetFolderItemsAsync("0", 100);



            return items.Entries;
        }


        [HttpPost(Name = "uploadImage")]
        public async Task<string> Post()
        {
           
            string clientId = "4m8ccnmh2oy629pqv52hlt710nfpa586";
            string clientSecret = "idiyrJaC1EmRI9driFUhEs7ww93TGiMM";
            string devToken = "RuMv5ewxBL8BnRsEfZjwPme1n6tI2DyI";
            var boxConfig = new BoxConfig(clientId, clientSecret, new Uri("http://localhost"));
            var boxJWTAuth = new BoxJWTAuth(boxConfig);
            var boxClient = boxJWTAuth.AdminClient(devToken);
            using (var stream = new FileStream("Dummy.txt", FileMode.Open))
            {
                var fileRequest = new BoxFileRequest
                {
                    Name = Path.GetFileName("Dummy.txt"),
                    Parent = new BoxRequestEntity { Id = "0", Type = BoxType.file },
                };

                var uplaodedFile = await boxClient.FilesManager.UploadAsync(fileRequest, stream);
            }



            return "file uploaded";
        }

    }
}