using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    //Burada connection string tanımlanacak.Bir app yada form olssas app.config de tanımlayacaktık bu connection stringi.
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-DA8EVG9\\SQLEXPRESS;database=CoreBlogDb; integrated security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Contect> Contects{ get; set; }
        public DbSet<Writer> Writers{ get; set; }
    }
}
