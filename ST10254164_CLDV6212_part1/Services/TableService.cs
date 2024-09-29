using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using ST10254164_CLDV6212_GR2_part1.Models;
using System.Threading.Tasks;

//********************************************START OF FILE**********************************//
namespace ST10254164_CLDV6212_GR2_part1.Services
{
    public class TableService
    {
        private readonly TableClient _tableClient;

        public TableService(IConfiguration configuration)
        {
            var connectionString = configuration["AzureStorage:ConnectionString"];
            var servcieClient = new TableServiceClient(connectionString);
            _tableClient = servcieClient.GetTableClient("CustomerProfiles");
            _tableClient.CreateIfNotExists();
        }
        public async Task AddEntityAsync(CustomerProfiles profile)
        {
            await _tableClient.AddEntityAsync(profile);
        }
    }
}
//*************************************END OF FILE***********************************************//