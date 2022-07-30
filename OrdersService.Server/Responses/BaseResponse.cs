using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Server.Responses
{
    [MessageContract]
    public class BaseResponse
    {
        /// <summary>
        /// Default = true
        /// </summary>
        [MessageHeader]
        public bool IsSuccess { get; set; } = true;
        [MessageHeader]
        public string Message { get; set; }
    }
}
