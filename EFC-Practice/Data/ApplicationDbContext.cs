namespace EFC_Practice.Data
{
using EFC_Practice.Models;
using Microsoft.EntityFrameworkCore;



    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
