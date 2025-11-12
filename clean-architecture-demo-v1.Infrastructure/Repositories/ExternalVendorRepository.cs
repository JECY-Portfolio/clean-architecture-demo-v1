using clean_architecture_demo_v1.Core.Interfaces;
using clean_architecture_demo_v1.Core.Models;
using clean_architecture_demo_v1.Infrastructure.Services;

namespace clean_architecture_demo_v1.Infrastructure.Repositories
{
    public class ExternalVendorRepository(ICoindeskHttpClientService coindeskHttpClientService, 
        IJokeHttpClientService jokeHttpClientService) 
        : IExternalVendorRepository

    {
        public async Task<CoindeskData> GetData()
        {
            return await coindeskHttpClientService.GetData();
        }
        public async Task<JokeModel> GetJoke()
        {
            return await jokeHttpClientService.GetData();
        }

    }
}
