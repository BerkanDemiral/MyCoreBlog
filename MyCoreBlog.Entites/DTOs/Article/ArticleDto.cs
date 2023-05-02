namespace MyCoreBlog.DTOs.Article
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public int ArticleViewCount { get; set; }
        public virtual DateTime CreatedDate { get; set; } 
        public virtual string CreatedBy { get; set; }

    }
}
