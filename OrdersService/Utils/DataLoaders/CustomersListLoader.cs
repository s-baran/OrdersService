using AutoMapper;
using OrdersService.Core.OrderService;
using OrdersService.IoC;
using OrdersService.Models;
using System;
using System.Collections.Generic;

namespace OrdersService.Utils.DataLoaders
{
    public class CustomersListLoader : DataLoader<List<CustomerDetails>>
    {
        public override List<CustomerDetails> Load()
        {
            var mapper = IocKernel.Get<Mapper>();
            var response = orderService.GetAllCustomers(new BaseRequest());
            if (!response.IsSuccess)
            {
                throw new Exception("Couldnt get customers");
            }
            else
            {
                return mapper.Map<List<CustomerDetails>>(response.Customers);
            }
        }
    }
}
