using MyCoreBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Entites.Entities
{
    public class Article : BaseEntity
    {
        public Article()
        {

        }

        public Article(string articleTitle, string articleContent, Guid? ımageId, Guid categoryId, Guid userId)
        {
            ArticleTitle = articleTitle;
            ArticleContent = articleContent;
            ImageId = ımageId;
            CategoryId = categoryId;
            UserId = userId;
        }

        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public int ArticleViewCount { get; set; } = 0;
        public Guid? ImageId { get; set; } 
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public Image? Image { get; set; } // fotoğrafı olmayan articleler olabilir bu nedenle ? konulmazsa migration kısmında ForeignKey_ImageId hatası atar....

        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
