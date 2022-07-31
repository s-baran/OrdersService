using System.ServiceModel;

namespace OrdersService.Server.Requests
{
    [MessageContract]
    public class RemoveOrderRequest : BaseRequest
    {
        [MessageHeader]
        public int OrderId { get; set; }
    }
}
