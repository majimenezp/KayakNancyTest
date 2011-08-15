using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
namespace KayakNancyTest01.Controllers
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = x =>
            {
                var model = new { Title = "Homepage" };
                return View["Views/Index.cshtml", model];
            };
            Get["/img/{archivo}"] = x =>
            {
                return Response.AsImage("Assets/img/" + (string)x.archivo);
            };
            Get["/css/{archivo}"] = x =>
            {
                return Response.AsImage("Assets/css/" + (string)x.archivo);
            };
            Get["/js/{archivo}"] = x =>
            {
                return Response.AsImage("Assets/js/" + (string)x.archivo);
            };
        }

    }
}
