using OrdersService.Common.Models;
using OrdersService.DB.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Server.Utils.Converters
{
    public static class DBDataConverter
    {
        public static DBOrder Convert(OrderDto order) => MapperResolver.Mapper.Map<DBOrder>(order);
        public static OrderDto Convert(DBOrder order) => MapperResolver.Mapper.Map<OrderDto>(order);
        public static List<OrderDto> Convert(List<DBOrder> orders)
        {
            var list = new List<OrderDto>();
            foreach (DBOrder order in orders)
            {
                list.Add(Convert(order));
            }

            return list;
        }

        internal static List<ItemDto> Convert(List<DBItem> items)
        {
            var itemsList = new List<ItemDto>();
            foreach (DBItem item in items)
            {
                itemsList.Add(Convert(item));
            }
            return itemsList;
        }

        private static ItemDto Convert(DBItem item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Price = item.Price,
                Name = item.Name
            };
        }

        public static CustomerDto Convert(DBCustomer customerDetails)
        {
            CustomerDto customer = new CustomerDto
            {
                Id = customerDetails.Id,
                FirstName = customerDetails.FirstName,
                Address = customerDetails.Address,
                LastName = customerDetails.LastName,
                PhoneNumber = customerDetails.PhoneNumber
            };
            return customer;
        }

        public static List<OrderItemDto> Convert(List<DBOrderItem> items)
        {
            List<OrderItemDto> list = new List<OrderItemDto>();
            foreach (DBOrderItem item in items)
            {
                list.Add(Convert(item));
            }
            return list;
        }

        private static OrderItemDto Convert(DBOrderItem item)
        {
            return new OrderItemDto
            {
                Id = item.ItemId,
                Name = item.Name,
                Price = item.Price,
                Quantity = item.Quantity
            };
        }
    }
}
