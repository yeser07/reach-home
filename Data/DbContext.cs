using Microsoft.EntityFrameworkCore;
using Reach_Home.Models;

namespace Reach_Home.Data;

public class ApplicationDbContext:DbContext
{
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<Rol> Roles { get; set; }
     public DbSet<Usuario> Usuarios { get; set; }

}

