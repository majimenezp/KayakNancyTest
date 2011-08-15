using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gate;
using Nancy.Hosting.Owin;

namespace KayakNancyTest01
{
    public static class Extensions
    {
        // a bit of sugar for running Nancy ;)
        public static IAppBuilder RunNancy(this IAppBuilder builder)
        {
            return builder.Run(Delegates.ToDelegate(new NancyOwinHost().ProcessRequest));
        }
    }
}
