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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BitCalculator(DataModel @dataModel)
        {
            //TO DO get array of table elements and fill the page from new model
            TableDataModel tableData = new TableDataModel();
            tableData.GetParams(@dataModel);
            return View(tableData);
        }

    }
}