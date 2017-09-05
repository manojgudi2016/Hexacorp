using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //public async Task<string> Index()
        //{

        //    DateTime dt1 = DateTime.Now; 
        //    Task<int> t1 = Operation1(); 
        //    Task<int> t2 = Operation2(); 
        //    Task<int> t3 = Operation3(); 
        //    await Task.WhenAll(t1, t2, t3); 
        //    int op1 = await t1;
        //    int op2 = await t2; 
        //    int op3 = await t3; 
        //    DateTime dt2 = DateTime.Now;
        //    ViewBag.TotalTime = dt2 - dt1; return (dt2 - dt1).ToString();

        //    return Content(ViewBag.TotalTime);
        //}
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";

            return View();
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

        private async Task<int> Operation1()
        {
            await Task.Run(() => { System.Threading.Thread.Sleep(1000); });
            return 100;
        }


        private async Task<int> Operation2()
        {
            await Task.Run(() => { System.Threading.Thread.Sleep(1000); });
            return 100;
        }


        private async Task<int> Operation3()
        {
            await Task.Run(() => { System.Threading.Thread.Sleep(1000); });
            return 100;
        }

        public async Task<string> AsyncDemo()
        {
            DateTime dt1 = DateTime.Now;
            int op1 = await Operation1();
            int op2 = await Operation2();
            int op3 = await Operation3();
            DateTime dt2 = DateTime.Now;
            ViewBag.TotalTime = dt2 - dt1; return (dt2 - dt1).ToString();

        }
    }
}