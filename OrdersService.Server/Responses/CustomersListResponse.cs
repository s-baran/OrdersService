using OrdersService.Common.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace OrdersService.Server.Responses
{
    [MessageContract]
    public class CustomersListResponse : BaseResponse
    {
        [MessageBodyMember]
        public List<CustomerDto> Customers { get; set; }
    }
}
