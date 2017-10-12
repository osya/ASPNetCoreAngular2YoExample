using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreAngular2YoExample.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
		[ServiceFilter(typeof(AngularAntiForgeryTokenAttribute), IsReusable = true)]    // Send new antiforgery token
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
