using OrdersService.Server.Requests;
using OrdersService.Server.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Server.Contracts
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        OrdersListResponse GetAllOrders(BaseRequest request);
    }
}
