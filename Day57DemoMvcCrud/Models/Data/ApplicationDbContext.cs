using Microsoft.EntityFrameworkCore;

namespace Day57DemoMvcCrud.Models.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UserManagement;Integrated Security=True");
    }
}