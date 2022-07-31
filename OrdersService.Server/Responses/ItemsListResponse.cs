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
    public class ItemsListResponse : BaseResponse
    {
        [MessageBodyMember]
        public List<ItemDto> Items { get; set; }
    }
}
