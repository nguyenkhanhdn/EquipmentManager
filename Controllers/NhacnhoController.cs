using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquipmentManager.Controllers
{
    [Authorize]
    public class NhacnhoController : Controller
    {
        // GET: Nhacnho
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}