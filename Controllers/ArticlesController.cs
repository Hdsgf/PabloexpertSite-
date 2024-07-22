using Microsoft.AspNetCore.Mvc;

namespace PabloexpertBlog.Controllers
{
    public class ArticlesController : Controller //articles
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
