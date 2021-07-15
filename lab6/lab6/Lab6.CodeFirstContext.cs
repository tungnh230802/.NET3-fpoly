using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext() : base("name=CompanyConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists < CodeFirstContext > ());
        }

        public DbSet < Company > Companies
        {
            get;
            set;
        }
    }
}
