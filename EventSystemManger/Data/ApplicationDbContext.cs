using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EventSystemManger.Models;

namespace EventSystemManger.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EventSystemManger.Models.Event> Event { get; set; } = default!;
        public DbSet<EventSystemManger.Models.Participant> Participant { get; set; } = default!;
        public DbSet<EventSystemManger.Models.Registration> Registration { get; set; } = default!;
    }
}
