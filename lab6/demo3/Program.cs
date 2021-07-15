using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new BloggingContext())
            {
                db.Database.CreateIfNotExists();

                Console.WriteLine("name a new blog: ");
                var name = Console.ReadLine();

                var blog = new Blog() { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                var query = from b in db.Blogs
                            orderby b.Name
                            select b;
                Console.WriteLine("all blogs in database");
                foreach(var item in query)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}
