using Microsoft.AspNetCore.Mvc;

namespace CRUD_Operations.Controllers
{
    public class myController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
