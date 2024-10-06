using DOMAIN.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace INFRA.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Customer> Customer { get; set; }

    public DbSet<Order> Order { get; set; }
}