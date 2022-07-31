using AutoMapper;
using Ninject.Modules;
using OrdersService.Utils;
using OrdersService.Utils.MapperConfigurations;
using OrdersService.Views;

namespace OrdersService.IoC
{
    public class IocConfiguration : NinjectModule
    {
        public override void Load()
        {
            Bind<NavigationService>().ToSelf().InSingletonScope();
            Bind<OrdersListView>().ToSelf().InSingletonScope();
            Bind<OrderDetailsView>().ToSelf().InSingletonScope();
            Bind<Mapper>().ToSelf().InSingletonScope().WithConstructorArgument("configurationProvider", new ConfigurationGenerator().GetConfiguration());
        }
    } 
}
