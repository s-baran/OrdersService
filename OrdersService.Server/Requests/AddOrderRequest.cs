using OrdersService.Common.Models;
using System.ServiceModel;

namespace OrdersService.Server.Requests
{
    [MessageContract]
    public class AddOrderRequest : BaseRequest
    {
        [MessageBodyMember]
        public CreateOrderModelDto CreateOrderModel { get; set; }
    }
}
