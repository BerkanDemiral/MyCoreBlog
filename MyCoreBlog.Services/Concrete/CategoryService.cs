using AutoMapper;
using MyCoreBlog.DataAccess.UnitOfWorks;
using MyCoreBlog.DTOs.Article;
using MyCoreBlog.Entites.DTOs.Categories;
using MyCoreBlog.Entites.Entities;
using MyCoreBlog.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<CategoryDto>> GetAllCategoriesAsync()
        {
            var categories = await _unitOfWork.GetRepository<Category>().GetAllAsync();
            var mappedCategories = _mapper.Map<List<CategoryDto>>(categories);
            return mappedCategories; 
        }

        public async Task<List<CategoryDto>> GetAllCategoriesNotDeletedAsync()
        {
            var categories = await _unitOfWork.GetRepository<Category>().GetAllAsync(x=>!x.isDeleted);
            var mappedCategories = _mapper.Map<List<CategoryDto>>(categories);
            return mappedCategories;
        }
    }
}
