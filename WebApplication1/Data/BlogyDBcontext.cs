using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Domian;

namespace WebApplication1.Data
{
    public class BlogyDBcontext : DbContext

    {
        public BlogyDBcontext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
