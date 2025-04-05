using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPlanner.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Persistence
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public DbSet<Email> Emails { get; set; }
    }
}
