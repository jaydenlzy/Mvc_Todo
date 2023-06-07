using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mvc_Todo.Areas.Identity.Data;
using Mvc_Todo.Models;

namespace Mvc_Todo.Data;

public class Mvc_TodoContext : IdentityDbContext<Mvc_TodoUser>
{
    public Mvc_TodoContext(DbContextOptions<Mvc_TodoContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<Mvc_Todo.Models.ToDo>? ToDo { get; set; }
}
