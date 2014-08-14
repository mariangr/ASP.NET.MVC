using BitCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BitCalculator.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult BitCalculator(DataModel @dataModel)
        {
            @dataModel.setTableData();
            if (Request.IsAjaxRequest())
            {
                return PartialView("_TablePartial", @dataModel);
            }
            return View(@dataModel);
        }
    }
}