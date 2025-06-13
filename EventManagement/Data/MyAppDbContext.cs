using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventManagement.Models;

namespace EventManagement.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext (DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<EventManagement.Models.Events> Events { get; set; } = default!;
        public DbSet<EventManagement.Models.Booking> Bookings { get; set; } = default!;

        public DbSet<EventManagement.Models.UserAccounts> UserAccounts { get; set; } = default!;    

    }
}
