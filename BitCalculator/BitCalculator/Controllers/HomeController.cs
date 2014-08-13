using BitCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitCalculator.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index(DataModel @dataModel)
        {
            //return Json(@dataModel.ToString());
            return View(@dataModel);
        }

    }
}