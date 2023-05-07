using AutoMapper;
using MyCoreBlog.DataAccess.UnitOfWorks;
using MyCoreBlog.DTOs.Article;
using MyCoreBlog.Entites.DTOs.Article;
using MyCoreBlog.Entites.Entities;
using MyCoreBlog.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Services.Concrete
{
    public class ArticleService :IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var adminUserId = Guid.Parse("C293C647-06B4-42D5-9431-D31353E35B0C");
            var imageId = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214");
            var article = new Article(articleAddDto.ArticleTitle, articleAddDto.ArticleContent,imageId, articleAddDto.CategoryId, adminUserId);

            await _unitOfWork.GetRepository<Article>().AddAsync(article); // Bir DTO'yu Bellekte Article(Entity) için eklemesi isteniyorsa yapılır. ZORUNLUDUR
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x=>x.Category);
            var mappedArticles = _mapper.Map<List<ArticleDto>>(articles);
            return mappedArticles;
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNotDeletedAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllActiveAsync(x=>!x.isDeleted, x=>x.Category);
            var mappedArticles = _mapper.Map<List<ArticleDto>>(articles);
            return mappedArticles;
        }

        public async Task<ArticleDto> GetArticleWithCategoryAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(x=>x.Id == articleId ,x => x.Category);
            var mappedArticle = _mapper.Map<ArticleDto>(article);
            return mappedArticle;
        }

        public async Task<ArticleDto> GetArticleWithCategoryNotDeletedAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetActiveAsync(x => !x.isDeleted && x.Id == articleId, x => x.Category);
            var mappedArticle = _mapper.Map<ArticleDto>(article);
            return mappedArticle;
        }

        public async Task SafeDeleteArticleAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetByIdAsyncs(articleId);
            article.isDeleted = true;
            article.DeletedDate= DateTime.Now;
            await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateArticle(ArticleUpdateDto articleUpdateDto)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(x=>x.Id == articleUpdateDto.Id, x => x.Category);
            var mappedArticle = _mapper.Map<ArticleUpdateDto, Article>(articleUpdateDto, article); // Bir nevi Lazy Mapping...

            await _unitOfWork.GetRepository<Article>().UpdateAsync(mappedArticle);
            await _unitOfWork.SaveAsync();
        }
    }
}
