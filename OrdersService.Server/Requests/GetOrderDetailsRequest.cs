using System.ServiceModel;

namespace OrdersService.Server.Requests
{
    [MessageContract]
    public class GetOrderDetailsRequest : BaseRequest
    {
        [MessageHeader]
        public int RequestId { get; set; }

    }
}
