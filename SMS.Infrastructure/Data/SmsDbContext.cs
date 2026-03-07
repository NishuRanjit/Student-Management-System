using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMS.Domain.Entities;
namespace SMS.Infrastructure.Data
    
{
    public class SmsDbContext : IdentityDbContext {
        public SmsDbContext(DbContextOptions<SmsDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }

    
}
