using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ctor for constructor shortcut and double tab
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // prop for proprety
        public DbSet<Item> Item{ get; set; }    
        public DbSet<Expenses> Expenses { get; set; }     
        

    }
}
