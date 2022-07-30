using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using OrdersService.Common.Models;

namespace OrdersService.Server.Responses
{
    [MessageContract]
    public class OrdersListResponse : BaseResponse
    {
        [MessageBodyMember]
        public IEnumerable<Order> Orders { get; set; }
    }
}
