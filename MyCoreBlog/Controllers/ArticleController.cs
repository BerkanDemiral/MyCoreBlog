using Microsoft.AspNetCore.Mvc;

namespace MyCoreBlog.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
