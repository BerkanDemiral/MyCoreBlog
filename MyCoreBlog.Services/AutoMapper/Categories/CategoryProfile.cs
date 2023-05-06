using AutoMapper;
using MyCoreBlog.Entites.DTOs.Categories;
using MyCoreBlog.Entites.Entities;

namespace MyCoreBlog.Services.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
        }
    }
}
