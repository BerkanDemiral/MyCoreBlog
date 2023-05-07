using AutoMapper;
using MyCoreBlog.DTOs.Article;
using MyCoreBlog.Entites.DTOs.Article;
using MyCoreBlog.Entites.Entities;

namespace MyCoreBlog.Services.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
            CreateMap<ArticleAddDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, ArticleDto>().ReverseMap();
            CreateMap<ArticleUpdateDto, Article>().ReverseMap();

        }
    }
}
