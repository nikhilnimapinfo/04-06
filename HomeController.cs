using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagAndViewData.Models;

namespace ViewBagAndViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Name = "Thane And Mumbai IS Near By";
            ViewBag.MyList=new List<string>() { "Thane","Mumbai","Mulund","GhatKoper","Panvel","Badlapur"};


            List<Class1> list = new List<Class1>() { 
                new Class1()
                {
                    Id =10,
                    Name="AA",
                    Addr="Mumbai"
                }

                ,
                new Class1()
                {
                    Id =11,
                    Name="BB",
                    Addr="Thane"
                },
                new Class1()
                {
                    Id =12,
                    Name="CC",
                    Addr="Mulund"
                }

            };
            ViewBag.NewData=list;
            return View();
        }
    }
}