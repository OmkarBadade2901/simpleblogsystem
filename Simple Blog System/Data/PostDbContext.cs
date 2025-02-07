

using Microsoft.EntityFrameworkCore;
using Simple_Blog_System.Models;

namespace Simple_Blog_System.Data
{
    public class PostDbContext : DbContext
    {

        public PostDbContext( DbContextOptions<PostDbContext> options) : base(options) { }
       

        public DbSet<Post> Posts { get; set; }
    }
}
