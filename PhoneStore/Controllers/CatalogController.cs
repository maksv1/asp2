using Microsoft.AspNetCore.Mvc;

namespace PhoneStore.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
