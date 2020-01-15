using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIControllerWithDatabase.Models
{
    public class APIControllerWithDatabaseContext : DbContext
    {
        public APIControllerWithDatabaseContext (DbContextOptions<APIControllerWithDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<APIControllerWithDatabase.Models.Reservation> Reservation { get; set; }
    }
}
