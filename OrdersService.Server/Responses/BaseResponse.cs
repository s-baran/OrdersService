using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Server.Responses
{
    [ServiceKnownType(typeof(OrdersListResponse))]
    [MessageContract]
    public class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
