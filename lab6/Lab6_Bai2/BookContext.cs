using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Bai2
{
    public class BookContext : DbContext
    {
        public BookContext() : base("name=BookConnectionString")
        {
            var initializer = new MigrateDatabaseToLatestVersion<BookContext,
                Migrations.Configuration>();
            Database.SetInitializer(initializer);

            //Database.SetInitializer(new DropCreateDatabaseAlways<BookContext>());
        }

        public DbSet <Book> Books { get; set; }
        public DbSet <Category> Category { get; set; }
    }
}
