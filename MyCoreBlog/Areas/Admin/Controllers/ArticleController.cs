using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCoreBlog.DTOs.Article;
using MyCoreBlog.Services.Abstract;

namespace MyCoreBlog.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize]
	public class ArticleController : Controller
	{
		private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
		public async Task<IActionResult> Index()
		{
			var articles = await _articleService.GetAllArticlesWithCategoryAsync();
			return View(articles);
		}
	}
}
