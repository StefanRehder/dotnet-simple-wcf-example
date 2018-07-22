using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using HeroServiceContracts;

namespace SelfHostedWCFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(HeroService), new Uri("http://localhost:8080"));
            ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IHeroService), new WebHttpBinding(), "");
            ServiceDebugBehavior stp = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            stp.HttpHelpPageEnabled = false;
            host.Open();
            Console.WriteLine("The service is up and running on http://localhost:8080");
            Console.WriteLine("Press [Enter] to close the host.");
            Console.ReadLine();
            host.Close();
        }
    }
}
