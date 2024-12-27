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

            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("http://localhost:5096/api/ProductDetails/GetProductDetailByProductId?id=" + id);
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            var values1 = JsonConvert.DeserializeObject<GetProductDetailByIdDto>(jsonData1);


            

            ViewBag.bathCount = values1.bathCount;

            return View();
            
        }
    }
}
