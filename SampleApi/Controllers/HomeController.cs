using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SqlExpressNovember;
using SqlExpressNovember.EntityClasses;

namespace SampleApi.Controllers
{
    public class HomeController : Controller
    {
        public string _connString = System.Configuration.ConfigurationManager.ConnectionStrings["EfConnString"].ToString();
         
        public ActionResult Index()
        {
            List<MovieResult> results = null;

            using (var context = new SqlExpressNovemberDataContext(_connString))
            {
                results = context.MovieResults.ToList();
            }

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
