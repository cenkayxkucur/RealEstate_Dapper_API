using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.ProductDetailDtos;
using RealEstate_Dapper_UI.Dtos.ProductDtos;

namespace RealEstate_Dapper_UI.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PropertyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5096/api/Products/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }

            return View();
        }

        public async Task<IActionResult> PropertyListWithSearch(string searchKeyValue, int propertyCategoryId, string city)
        {
            ViewBag.searchKeyValue = TempData["searchKeyValue"];    
            ViewBag.propertyCategoryId = TempData["propertyCategoryId"];
            ViewBag.city = TempData["city"];    
            searchKeyValue = TempData["searchKeyValue"].ToString();
            propertyCategoryId = int.Parse(TempData["propertyCategoryId"].ToString()); 
            city = TempData["city"].ToString();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5096/api/Products/ResultProductWithSearchList?searchKeyValue={searchKeyValue}&propertyCategoryId={propertyCategoryId}&city={city}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductWithSearchListDto>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PropertySingle(int id)
        {
            id = 1;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5096/api/Products/GetProductByProductId?id=" + id);           
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultProductDto>(jsonData);

            ViewBag.title1 = values.title.ToString();
            ViewBag.city = values.city;
            ViewBag.district = values.district;
            ViewBag.address = values.address;
            ViewBag.type = values.type;
            ViewBag.price = values.price;
            ViewBag.description = values.description;
            ViewBag.productId = values.productID;
            ViewBag.advertisementDate = values.advertisementDate;
            
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("http://localhost:5096/api/ProductDetails/GetProductDetailByProductId?id=" + id);
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            var values1 = JsonConvert.DeserializeObject<GetProductDetailByIdDto>(jsonData1);
            

            ViewBag.bathCount = values1.bathCount;
            ViewBag.bedRoomCount = values1.bedRoomCount;
            ViewBag.size = values1.productSize;
            ViewBag.roomCount = values1.roomCount;
            ViewBag.garageSize = values1.garageSize;
            ViewBag.buildYear = values1.buildYear;
            ViewBag.location = values1.location;
            ViewBag.videoUrl = values1.videoUrl;
            DateTime date1 = DateTime.Now;
            DateTime date2 = values.advertisementDate;
            TimeSpan timeSpan = date1 - date2;  
            int month = timeSpan.Days;

            ViewBag.datediff = month / 30;
            return View();
            
        }
    }
}
