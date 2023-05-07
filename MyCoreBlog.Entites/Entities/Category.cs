using MyCoreBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Entites.Entities
{
    public class Category : BaseEntity
    {
        public Category() { }

        public Category(string categoryName, ICollection<Article> articles)
        {
            CategoryName = categoryName;
        }

        public string CategoryName { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
