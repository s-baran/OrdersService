using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Models.Report
{
    public class QuarterReportItem
    {
        public string ProductName { get; set; }
        public decimal Quarter1 { get; set; }
        public decimal Quarter2 { get; set; }
        public decimal Quarter3 { get; set; }
        public decimal Quarter4 { get; set; }
    }
}
