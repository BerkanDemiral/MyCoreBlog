using AutoMapper;
using MyCoreBlog.DataAccess.UnitOfWorks;
using MyCoreBlog.DTOs.Article;
using MyCoreBlog.Entites.Entities;
using MyCoreBlog.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
