﻿using Azure.Storage.Queues;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

//********************************************START OF FILE**********************************//
namespace ST10254164_CLDV6212_GR2_part1.Services
{
    public class QueueService
    {
        private readonly QueueServiceClient _queueServiceClient;

        public QueueService(IConfiguration configuration)
        {
            _queueServiceClient = new QueueServiceClient(configuration["AzureStorage:ConnectionString"]);
        }

        public async Task SendMessageAsync(string queueName, string message)
        {
            var queueClient = _queueServiceClient.GetQueueClient(queueName);
            await queueClient.CreateIfNotExistsAsync();
            await queueClient.SendMessageAsync(message);
        }
    }
}
//*************************************END OF FILE***********************************************//