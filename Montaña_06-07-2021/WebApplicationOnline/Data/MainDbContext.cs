using Microsoft.EntityFrameworkCore;
using WebApplicationOnline.Entities;


namespace WebApplicationOnline.Data
{
    public class MainDbContext : DbContext
    {
        public DbSet<Mountain> Mountains { get; set; }

        //constructor
        public MainDbContext(DbContextOptions<MainDbContext>dbContextOptions):base(dbContextOptions)
        { 

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //  => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mountain;Integrated Security=True;");
    }
}
