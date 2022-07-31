using System.ServiceModel;

namespace OrdersService.Server.Requests
{
    [MessageContract]
    public class GetOrderDetailsRequest : BaseRequest
    {
        [MessageHeader]
        public int OrderId { get; set; }

    }
}
