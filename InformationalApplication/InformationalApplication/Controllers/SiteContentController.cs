using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InformationalApplication.Controllers
{
    public class SiteContentController : Controller
    {

        public ActionResult ReturnPartialView(string pageName)
        {
            return PartialView(pageName);
        }

	}
}