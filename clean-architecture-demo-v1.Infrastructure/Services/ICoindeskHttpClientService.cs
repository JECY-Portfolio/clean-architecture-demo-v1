using clean_architecture_demo_v1.Core.Models;

public interface ICoindeskHttpClientService
{
    Task<CoindeskData> GetData();
}
