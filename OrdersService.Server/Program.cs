using OrdersService.Server.Utils;

namespace OrdersService.Server
{
    class Program
    {
      
        static void Main(string[] args)
        {
            ConfigureAutoMapper();
            var serviceRunner = new ServiceRunner(args);
            serviceRunner.Run();
        }

        private static void ConfigureAutoMapper()
        {
            MapperResolver.Initialize();
        }
    }
}
