namespace WebApplication1.Models.Domian
{
    public class BlogPost
    {
        public Guid ID { get; set; }   
        public string Heading { get; set; }   
        public string PageTitle { get; set; }   
        public string Content { get; set; }   
        public string ShortDescrip { get; set; }  
        public string FeaturedImageURL { get; set; }    
        public string URLHandle { get; set; }   
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }   
        public ICollection<Tag> Tags { get; set; }

    }
}
