﻿using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Controllers;
using System.Net.Http;

namespace RealEstate_Dapper_UI.ViewComponents.Dashboard
{
    public class _DashboardStatisticsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

        }
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            #region İstatistik1 = ToplamİlanSayısı
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("http://localhost:5096/api/Statistics/ProductCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData1;
            #endregion

            #region İstatistik2= EnBaşarılıPersonel
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:5096/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsonData2;
            #endregion

            #region İstatistik3 = İlandakiŞehirSayıları
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("http://localhost:5096/api/Statistics/DifferentCityCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.differentCityCount = jsonData3;
            #endregion

            #region İstatistik4 = OrtalamaKiraDeğeri
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("http://localhost:5096/api/Statistics/AverageProductPriceBySale");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsonData4;
            #endregion

            return View();
        }

    }
}
