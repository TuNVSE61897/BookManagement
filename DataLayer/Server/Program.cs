using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(BussinessLogic)))
            {
                host.Open();
                Console.WriteLine("Server Start!!!!!!!");
                Console.WriteLine("Press <Enter> to close server!");
                Console.ReadLine();
            }
        }
    }
}
