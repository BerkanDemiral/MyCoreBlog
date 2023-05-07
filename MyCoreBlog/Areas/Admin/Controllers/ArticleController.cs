using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCoreBlog.Entites.DTOs.Article;
using MyCoreBlog.Services.Abstract;

namespace MyCoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllArticlesWithCategoryAsync();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> AddArticle()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return View(new ArticleAddDto { Categories = categories });
        }

        [HttpPost]
        public async Task<IActionResult> AddArticle(ArticleAddDto articleAddDto)
        {
            //if (ModelState.IsValid)
            //{
            await _articleService.CreateArticleAsync(articleAddDto);
            return RedirectToAction("Index", "Article", new { Area = "Admin" });

            //}
            //else
            //{
            //    var categories = await _categoryService.GetAllCategoriesAsync();
            //    return View(new ArticleAddDto { Categories = categories });
            //}
        }

        [HttpGet]
        public async Task<IActionResult> UpdateArticle(Guid articleRowId)
        {
            var article = await _articleService.GetArticleWithCategoryAsync(articleRowId);
            var categories = await _categoryService.GetAllCategoriesAsync();

            var articleUpdateDto = _mapper.Map<ArticleUpdateDto>(article);
            articleUpdateDto.Categories = categories;
            return View(articleUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateArticle(ArticleUpdateDto articleUpdateDto)
        {
            //if (ModelState.IsValid){
            await _articleService.UpdateArticle(articleUpdateDto);
            return RedirectToAction("Index", "Article", new { Area = "Admin" });
            //}
            //else
            //{
            //    var categories = await _categoryService.GetAllCategoriesAsync();
            //    articleUpdateDto.Categories = categories;
            //    return View(articleUpdateDto);
            //}
        }

        public async Task<IActionResult> DeleteArticle(Guid articleRowId)
        {
            await _articleService.SafeDeleteArticleAsync(articleRowId);
            return RedirectToAction("Index", "Article", new { Area = "Admin" });
        }
    }
}
