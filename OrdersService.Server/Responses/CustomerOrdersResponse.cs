using OrdersService.Common.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace OrdersService.Server.Responses
{
    [MessageContract]
    public class CustomerOrdersResponse : BaseResponse
    {
        [MessageBodyMember]
        public List<CustomerOrderDto> CustomerOrders { get; set; }
    }
}
