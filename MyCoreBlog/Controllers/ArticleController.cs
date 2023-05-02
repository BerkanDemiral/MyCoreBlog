using Microsoft.AspNetCore.Mvc;
using MyCoreBlog.Services.Abstract;

namespace MyCoreBlog.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task<IActionResult> Index()
        {
            var Articles = await _articleService.GetAllArticlesAsync();
            return View(Articles);
        }
    }
}
