using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stx = new SchoolContext())
            {
                var stu = new Student()
                {
                    StudentName = "bill"
                };

                stx.Students.Add(stu);
                stx.SaveChanges();

                Console.ReadLine();
            }
        }
    }
}
