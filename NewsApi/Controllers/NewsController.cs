#region - Using

using Microsoft.AspNetCore.Mvc;
using NewsApi.Helper;
using NewsApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

#endregion

namespace NewsApi.Controllers
{
    public class NewsController : Controller
    {
        #region - Variable

        private readonly IAPIClient _apiClient;

        private string endpoint = "https://newsapi.org/v2/top-headlines";

        private readonly string country = "tr";
        private readonly string category = "technology";
        private readonly string apiKey = "Your_API_Key";

        #endregion

        #region - Ctor

        public NewsController(IAPIClient apiClient)
        {
            _apiClient = apiClient;
        }

        #endregion

        #region - Index

        public async Task<IActionResult> Index()
        {
            endpoint += $"?country={country}&category={category}&apiKey={apiKey}";


            var header = new Dictionary<string, string> { };

            var response = await _apiClient.GetAsync(endpoint, header);

            var rootobject = Newtonsoft.Json.JsonConvert.DeserializeObject<NewsResponseModel>(response.Data);

            return View(rootobject);
        }

        #endregion

    }
}