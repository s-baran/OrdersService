using OrdersService.Models.Report;
using System;
using System.Collections.Generic;

namespace OrdersService.Utils.DataLoaders
{
    internal class QuarterReportItemDataLoader : DataLoader<List<QuarterReportItem>>
    { 
        public override List<QuarterReportItem> Load()
        {

            return new List<QuarterReportItem>()
            {
                new QuarterReportItem()
                {
                    ProductName = "Product Name :)",
                    Quarter1 = 123M,
                    Quarter2 = 223.12M,
                    Quarter3 = 223.12M,
                    Quarter4 = 223.12M,
                }
            };
        }
    }
}
