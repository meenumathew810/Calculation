using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Currency.Controllers
{
    public class CurrencyController : Controller


        AccountsDbEntities
        // GET: Currency
        public ActionResult Index()
        {
            return View();
        }
    }
}