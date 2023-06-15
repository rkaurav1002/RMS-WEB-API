using AdminAPI.Models;
using AdminAPI.Models.UserRoles;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminAPI.Db;

public class AdminDbContext : IdentityDbContext<User>
{
    
    public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
    {
    }

    public DbSet<Question> Questions { get; set; } = null!;
    
}

