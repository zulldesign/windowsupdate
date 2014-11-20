using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Mvc.Facebook;
using Microsoft.AspNet.Mvc.Facebook.Client;
using MvcMusicStore.Models;

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
