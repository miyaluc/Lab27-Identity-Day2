using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab27_miya.Models
{
    public class lab27_miyaContext : DbContext
    {
        public lab27_miyaContext (DbContextOptions<lab27_miyaContext> options)
            : base(options)
        {
        }

        public DbSet<lab27_miya.Models.CPS> CPS { get; set; }
    }
}
