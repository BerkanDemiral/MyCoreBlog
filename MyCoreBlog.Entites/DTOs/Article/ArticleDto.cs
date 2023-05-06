using MyCoreBlog.Entites.DTOs.Categories;
using MyCoreBlog.Entites.Entities;

namespace MyCoreBlog.DTOs.Article
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string ArticleTitle { get; set; }
        public CategoryDto Category { get; set; }
        public virtual DateTime CreatedDate { get; set; } 
        public virtual string CreatedBy { get; set; }
        public bool isDeleted { get; set; }

    }
}
