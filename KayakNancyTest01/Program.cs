using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Gate;
using Gate.Helpers;
using Nancy.Hosting.Owin;
using Gate.Kayak;
namespace KayakNancyTest01
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpoint = new IPEndPoint(IPAddress.Any, 9191);
            KayakGate.Start(new SchedulerDelegate(), endpoint, Startup.Configuration);
            
            
        }
    }
}
