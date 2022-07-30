using OrdersService.Server.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Server
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var serviceRunner = new ServiceRunner(args);
            serviceRunner.Run();
        }
    }
}
