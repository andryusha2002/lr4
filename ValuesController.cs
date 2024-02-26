using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryappLr4
{
        public class HomeController : Controller
        {
            public ActionResult Index()
            {
                return Content("Привітання з бібліотеки!");
            }
        }
}
