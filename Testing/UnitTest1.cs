using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WeatherForecast()
        {
            var _httpClient = new HttpClient();
            var result = _httpClient.GetAsync($"https://localhost:5001/WeatherForecast").Result;
            // Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }
    }
}