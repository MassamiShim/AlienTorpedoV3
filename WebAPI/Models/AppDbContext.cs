using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<GroupEvent> GroupEvents { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

    }
}
