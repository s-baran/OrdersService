using OrdersService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Utils.DataLoaders
{
    public class ItemsLoader : DataLoader<List<Item>>
    {
        public override List<Item> Load()
        {
            var itemsList = new List<Item>();
            var response = orderService.GetAllItems(new Core.OrderService.BaseRequest());
            if (!response.IsSuccess)
            {
                return new List<Item>();
            }
            else
            {
                foreach (var item in response.Items)
                {
                    itemsList.Add(new Item()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Price = item.Price
                    });
                }
                return itemsList;
            }
        }
    }
}
