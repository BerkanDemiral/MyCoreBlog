using MyCoreBlog.DTOs.Article;
using MyCoreBlog.Entites.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllCategoriesAsync();
        Task<List<CategoryDto>> GetAllCategoriesNotDeletedAsync();
    }
}
