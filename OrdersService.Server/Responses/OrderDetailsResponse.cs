using OrdersService.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Server.Responses
{
    [MessageContract]
    public class OrderDetailsResponse : BaseResponse
    {
        [MessageBodyMember]
        public CustomerDto CustomerDetails { get; set; }
        [MessageBodyMember]
        public List<OrderItemDto> Items { get; set; }

    }
}
