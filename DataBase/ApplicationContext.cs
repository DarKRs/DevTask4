using Microsoft.EntityFrameworkCore;
using DataBase.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Furniture> furnitures { get; set; }    
        
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {
            Database.EnsureCreated();
            if (!furnitures.Any())
            {
                furnitures.Add(new Furniture() { Name = "Эверфлет",Type ="Стул", Size = "120cm" , Cost = 12000});
                furnitures.Add(new Furniture() { Name = "Андеркоут",Type = "Шкаф", Size = "200cm" , Cost = 45000});
                furnitures.Add(new Furniture() { Name = "Эверглейдс", Type = "Стол", Size = "140cm", Cost = 20000 });
                SaveChanges();
            }
        }
    }

    /// <summary>
    /// For Migrations
    /// </summary>
    public class AppContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=DevTask4;Trusted_Connection=True", b => b.MigrationsAssembly("DataBase"));

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
