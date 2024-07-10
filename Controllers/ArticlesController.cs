using Microsoft.AspNetCore.Mvc;

namespace PabloexpertBlog.Controllers
{
    public class ArticlesController : Controller // localhost:7208/articles
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
