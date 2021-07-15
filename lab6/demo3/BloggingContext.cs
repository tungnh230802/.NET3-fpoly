using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    class BloggingContext : DbContext
    {
        public BloggingContext() : base()
        {
            var initializer = new MigrateDatabaseToLatestVersion<BloggingContext,
                Migrations.Configuration>();

            Database.SetInitializer(initializer);
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .HasColumnName("display_name");
        }
    }
}
