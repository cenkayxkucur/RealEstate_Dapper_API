using Microsoft.AspNetCore.SignalR;

namespace RealEstate_Dapper_API.Hubs
{

    public class SignalRHub:Hub
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SignalRHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task SendCategoryCount()
        {
            #region İstatistik7
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("http://localhost:5096/api/Statistics/CategoryCount");
            var value1 = await responseMessage1.Content.ReadAsStringAsync();
            await Clients.All.SendAsync("RecieveCategoryCount", value1);
            #endregion
        }
    }
}
