using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfService;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(WcfService.WcfService));
            sh.Open();
            Console.WriteLine("Host je pokrenuo servis. Pritisnite <ENTER> za kraj servisa.");
            Console.ReadLine();
        }
    }
}
