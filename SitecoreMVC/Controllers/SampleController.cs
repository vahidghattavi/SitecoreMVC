using Glass.Mapper.Sc.Web.Mvc;
using SitecoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreMVC.Controllers
{
    public class SampleController : GlassController
    {
        // GET: Sample
        public ActionResult Listing()
        {
            var context = SitecoreContext.GetCurrentItem<IGlassBase>();
            return View("TestView");
        }
    }
}