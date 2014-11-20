using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;
using Facebook.Web;
using Facebook.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class OfficeController : Controller
    {
        //
        // GET: /Office/

        public ActionResult Index()
        {
            return View();
        }

    }
}
