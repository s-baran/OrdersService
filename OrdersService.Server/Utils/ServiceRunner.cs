using OrdersService.Server.Behaviours;
using OrdersService.Server.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Server.Utils
{
    public class ServiceRunner
    {
        private string[] args;

        public ServiceRunner(string[] args)
        {
            this.args = args;
        }


        internal void Run()
        {
            if (args.Length == 0)
                RunService();
            else
                ProcessArguments();
        }

        private void ProcessArguments()
        {
            //TODO: implement some logic 
        }

        private void RunService()
        {
            var uris = new Uri[1];
            uris[0] = new Uri("net.tcp://localhost:6565/OrderService");
            IOrderService service = new OrderService();
            ServiceHost host = new ServiceHost(service, uris);

            var binding = new NetTcpBinding(SecurityMode.None);
            host.AddServiceEndpoint(typeof(IOrderService), binding, "");

            var behaviorBase = new System.ServiceModel.Description.ServiceMetadataBehavior();
            behaviorBase.HttpGetEnabled = true;
            behaviorBase.HttpGetUrl = new Uri(@"http://localhost:6566/");

            host.Description.Behaviors.Add(behaviorBase);
            host.Opened += Host_Opened;
            host.Open();
            Console.ReadLine();
        }

        private void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Orders Service started");
        }
    }
}
