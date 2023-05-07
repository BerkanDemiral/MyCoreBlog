using MyCoreBlog.DataAccess.UnitOfWorks;
using MyCoreBlog.DTOs.Article;
using MyCoreBlog.Entites.DTOs.Article;
using MyCoreBlog.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Services.Abstract
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryAsync();
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNotDeletedAsync();
        Task<ArticleDto> GetArticleWithCategoryAsync(Guid articleId);
        Task<ArticleDto> GetArticleWithCategoryNotDeletedAsync(Guid articleId);
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
        Task UpdateArticle(ArticleUpdateDto articleUpdateDto);
        Task SafeDeleteArticleAsync(Guid articleId);
    }
}
