using Microsoft.EntityFrameworkCore;
using Model.DomainModel;

namespace Model
{
    
        public class Final_ProjectDbContext : DbContext
        {
            public DbSet<Product> Product { get; set; }
            public DbSet<Person> Person { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-AS4M13B;Initial Catalog=FinalProjectDb;Integrated Security=True;Trust Server Certificate=True");
            }
        }
    }


