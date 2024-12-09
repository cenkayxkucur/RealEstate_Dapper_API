﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region İstatistik1
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("http://localhost:5096/api/Statistics/ActiveCategoryCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData1;
            #endregion
            #region İstatistik2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5096/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData2;
            #endregion
            #region İstatistik3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("http://localhost:5096/api/Statistics/ApartmentCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.apartmentCount = jsonData3;
            #endregion
            #region İstatistik4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("http://localhost:5096/api/Statistics/AverageProductPriceBySale");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsonData4;
            #endregion
            #region İstatistik5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("http://localhost:5096/api/Statistics/AverageProductPriceByRent");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRent = jsonData5;
            #endregion
            #region İstatistik6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("http://localhost:5096/api/Statistics/AverageRoomCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsonData6;
            #endregion
            #region İstatistik7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("http://localhost:5096/api/Statistics/CategoryCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsonData7;
            #endregion
            #region İstatistik8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("http://localhost:5096/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsonData8;
            #endregion
            #region İstatistik9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("http://localhost:5096/api/Statistics/CityNameByMaxProductCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaxProductCount = jsonData9;
            #endregion
            #region İstatistik10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("http://localhost:5096/api/Statistics/DifferentCityCount");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.differentCityCount = jsonData10;
            #endregion
            #region İstatistik11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("http://localhost:5096/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsonData11;
            #endregion
            #region İstatistik12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("http://localhost:5096/api/Statistics/LastProductPrice");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice = jsonData12;
            #endregion
            #region İstatistik13
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("http://localhost:5096/api/Statistics/NewestBuildingYear");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = jsonData13;
            #endregion
            #region İstatistik14
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("http://localhost:5096/api/Statistics/OldestBuildingYear");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsonData14;
            #endregion
            #region İstatistik15
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("http://localhost:5096/api/Statistics/PassiveCategoryCount");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsonData15;
            #endregion
            #region İstatistik16
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client16.GetAsync("http://localhost:5096/api/Statistics/ProductCount");
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData16;
            #endregion
            return View();
        }
    }
}
