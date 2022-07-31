using System.ServiceModel;

namespace OrdersService.Server.Requests
{
    [MessageContract]
    public class GetCustomerOrdersRequest : BaseRequest
    {
        [MessageHeader]
        public int CustomerId { get; set; }
    }
}
