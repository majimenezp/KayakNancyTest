using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gate;
using Gate.Kayak;
using Nancy.Hosting.Owin;
using Gate.Helpers;
namespace KayakNancyTest01
{
    public class Startup
    {
        public static void Configuration(IAppBuilder builder)
        {
            builder.RescheduleCallbacks().RunNancy();
        }
    }

    
}
