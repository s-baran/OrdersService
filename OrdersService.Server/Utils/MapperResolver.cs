using AutoMapper;
using OrdersService.Common.Models;
using OrdersService.DB.DatabaseModels;

namespace OrdersService.Server.Utils
{
    public static class MapperResolver
    {
        private static bool isInitialized;

        public static Mapper Mapper { get; private set; }

        public static void Initialize()
        {
            if (!isInitialized)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<DBOrder, OrderDto>()
                        .ForMember(dest => dest.OrderStatus, act => act.MapFrom(src => src.Status))
                        .ForMember(dest => dest.CreationDate, act => act.MapFrom(src => src.CreationTime));
                    cfg.CreateMap<OrderDto, DBOrder>()
                        .ForMember(dest => dest.Status, act => act.MapFrom(src => src.OrderStatus))
                        .ForMember(dest => dest.CreationTime, act => act.MapFrom(src => src.CreationDate));
                    cfg.CreateMap<OrderItemDto, DBOrderItem>()
                        .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.Id));
                    cfg.CreateMap<DBOrderItem, OrderItemDto>()
                        .ForMember(dest => dest.Id, act => act.MapFrom(src => src.ItemId));
                    cfg.CreateMap<DBCustomer, CustomerDto>();
                    cfg.CreateMap<CustomerDto, DBCustomer>();


                });
                Mapper = new Mapper(config);
                isInitialized = true;
            }
        }
    }
}
