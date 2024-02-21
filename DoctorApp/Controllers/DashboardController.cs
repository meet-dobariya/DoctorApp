using Microsoft.AspNetCore.Mvc;

namespace DoctorApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
