using Microsoft.AspNetCore.Mvc;

namespace MVC_Assm1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {           
            return RedirectToAction("AboutUs");
        }
        public string AboutUs()
        {
            return "this is About Us Action";
        }
    }
}
