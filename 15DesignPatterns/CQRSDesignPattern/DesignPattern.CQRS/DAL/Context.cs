using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DesignPattern.ChainOfResponsibility.DAL
{

    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;initial catalog=DesignPattern2;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
