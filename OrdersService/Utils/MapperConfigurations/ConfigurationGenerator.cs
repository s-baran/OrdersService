using AutoMapper;
using OrdersService.Core.OrderService;
using OrdersService.Models;

namespace OrdersService.Utils.MapperConfigurations
{
    public class ConfigurationGenerator 
    {
        public ConfigurationGenerator()
        { 
        }
        public MapperConfiguration GetConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerDto, CustomerDetails>();
                cfg.CreateMap<CustomerDetails, CustomerDto>();
                cfg.CreateMap<OrderItemDto, Item>();
                cfg.CreateMap<Item, OrderItemDto>();
                cfg.CreateMap<SelectableItem, Item>();
            });
        }
    }
}
