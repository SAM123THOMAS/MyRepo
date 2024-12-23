using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Newtonsoft.Json;

namespace ServiceNowDemo.Controllers
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

        public class Incident
        {
            public string short_description { get; set; }
        }
        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<string> Get()
        {
            string Result = string.Empty;
            string instanceUrl = "https://dev184355.service-now.com/";
            string userName = "admin";
            string password = "m1q=EV0iDT-e";
            var tableName = "incident";
            var endpoint = $"/api/now/table/{tableName}";
            var url = instanceUrl + endpoint;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{userName}:{password}"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authToken);

                var content = new StringContent(JsonConvert.SerializeObject
                    (new Incident { short_description = "Sample Incident" }), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                var jsonString = await response.Content.ReadAsStringAsync();
                Result = jsonString;


            }



            return Result;
        }
    }
}