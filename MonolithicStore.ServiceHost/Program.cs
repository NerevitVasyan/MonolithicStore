using MonolithicStore.BusinessLogic.Contracts;
using MonolithicStore.BusinessLogic.Services;
using MonolithicStore.DataAccess.Entities;
using MonolithicStore.DataAccess.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicStore.ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamesService = new GamesService(new EFRepository<Game>(new MonolithicStore.DataAccess.AppContext()));

            System.ServiceModel.ServiceHost host = 
                new System.ServiceModel.ServiceHost(gamesService, 
                new Uri("http://localhost:8733/Design_Time_Addresses/GamesStore"));


            host.AddServiceEndpoint(typeof(IGamesService),
                new BasicHttpBinding(),
                "");

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            smb.HttpGetUrl = new Uri("http://localhost:8733/Design_Time_Addresses/GamesStore/mex");
            host.Description.Behaviors.Add(smb);

            Console.WriteLine("Opening...");
            host.Open();
            Console.WriteLine("Opened");

            Console.WriteLine("Press exit to exit");
            while (Console.ReadLine() != "exit") { }

        }
    }
}
