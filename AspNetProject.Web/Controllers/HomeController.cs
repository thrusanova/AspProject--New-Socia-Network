using AspNetProject.Data;
using System.Web.Mvc.Expressions;
using System.Web.Mvc;

namespace AspNetProject.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IAppData data)
            : base(data)
            {
            }
        public ActionResult Index()
        {
          
        return this.View();
        }

        public ActionResult About()
        {


            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}