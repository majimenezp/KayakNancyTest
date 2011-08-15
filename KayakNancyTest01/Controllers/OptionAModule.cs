using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using KayakNancyTest01.Models;
namespace KayakNancyTest01.Controllers
{
    public class OptionAModule:NancyModule
    {
        public OptionAModule()
        {
            Get["/"] = x =>
            {
                List<DBItem> list1=new List<DBItem>();
                list1.Add(new DBItem(){ Id=1,Description="test1"});
                list1.Add(new DBItem(){ Id=2,Description="test2"});
                list1.Add(new DBItem(){ Id=3,Description="test3"});
                var model=new {Title="Option A page",Items=list1};
                return View["Views/OptionA/Index.cshtml",model];
            };
        }
    }
}
