using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Models.Report
{
    public class CustomerReportItem
    {
        public string OrderName { get; set; }
        public DateTime Created { get; set; }
        public OrderStatus CurrentStatus { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
