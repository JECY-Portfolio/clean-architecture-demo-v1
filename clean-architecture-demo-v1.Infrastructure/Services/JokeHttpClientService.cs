using clean_architecture_demo_v1.Core.Models;
using System.Net.Http.Json;

namespace clean_architecture_demo_v1.Infrastructure.Services
{
    public class JokeHttpClientService(HttpClient httpClient) : IJokeHttpClientService
    {
        public async Task<JokeModel> GetData()
        {
            return await httpClient.GetFromJsonAsync<JokeModel>("random_joke");
        }
    }
}
