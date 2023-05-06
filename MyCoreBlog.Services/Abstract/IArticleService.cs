using MyCoreBlog.DataAccess.UnitOfWorks;
using MyCoreBlog.DTOs.Article;
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
    }
}
