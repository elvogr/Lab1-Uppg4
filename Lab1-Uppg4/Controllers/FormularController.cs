using Microsoft.AspNetCore.Mvc;

namespace Lab1_Uppg4.Controllers
{
    public class FormularController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
