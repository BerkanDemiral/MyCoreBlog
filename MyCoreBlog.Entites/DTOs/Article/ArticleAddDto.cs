using MyCoreBlog.Entites.DTOs.Categories;
using MyCoreBlog.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Entites.DTOs.Article
{
    public class ArticleAddDto
    {
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public Guid CategoryId { get; set; }
        public IList<CategoryDto> Categories { get; set; } // dropdowna alabilmek için  -- Service katmanında DTO lar ile çalıştığını unutmaaaa
    }
}
