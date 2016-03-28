using System.Web.Mvc;

namespace Chloe.Web.Controllers
{
    public class DefaultController : Controller
    {
        public DefaultController()
        {

        }
        
        public ActionResult Index()
        {           
            return View();
        }
        
    }
}