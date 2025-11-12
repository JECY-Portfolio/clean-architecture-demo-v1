using clean_architecture_demo_v1.Core.Models;
using System.Net.Http.Json;

namespace clean_architecture_demo_v1.Infrastructure.Services
{
    public class CoindeskHttpClientService(HttpClient httpClient) : ICoindeskHttpClientService
    {
        public async Task<CoindeskData> GetData()
        {
            return await httpClient.GetFromJsonAsync<CoindeskData>("bpi/currentprice.json");
        }
    }
}
