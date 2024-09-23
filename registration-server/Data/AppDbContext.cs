using Microsoft.EntityFrameworkCore;
using registration_server.Models;
using System.Collections.Generic;

namespace registration_server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { Database.EnsureCreated(); }

        public DbSet<User> Users { get; set; }
    }
}
