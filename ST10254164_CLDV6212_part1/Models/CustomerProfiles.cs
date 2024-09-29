using Azure;
using Azure.Data.Tables;
using System;

//********************************************START OF FILE**********************************//
namespace ST10254164_CLDV6212_GR2_part1.Models
{
    public class CustomerProfiles : ITableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public CustomerProfiles()
        {
            PartitionKey = "CustomerProfiles";
            RowKey = Guid.NewGuid().ToString();
        }
    }

}
//*************************************END OF FILE***********************************************//