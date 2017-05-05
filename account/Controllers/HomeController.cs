using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using account.Models;

namespace account.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<Myclass>();
            Random c1= new Random();

         



            for (var i=1;i<=200;i++)
            {
                var c2 = c1.Next(1, 3);
                string type = "";
                if (c2 == 1) { type = "支出"; } else { type = "收入"; };
                 
                var a = new Random(Guid.NewGuid().GetHashCode());
                var b = a.Next();

                Random gen = new Random(Guid.NewGuid().GetHashCode());
                DateTime time;

                DateTime start = new DateTime(2016,1,1);
                int range = (DateTime.Today - start).Days;
                time = start.AddDays(gen.Next(range));

                DateTime c = DateTime.Now;
                model.Add(new Myclass
                {
                 num = i,
                    category = type,
                    money = b,
                    date =time

                });
                 
                
   
            }
          
            return View(model);
        }
       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     
       
    }
}