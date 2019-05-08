using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace InventoryControlAngularJS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : InventoryControlAngularJSControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}