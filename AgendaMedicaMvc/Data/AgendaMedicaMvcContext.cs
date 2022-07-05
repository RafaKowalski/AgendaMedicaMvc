using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgendaMedicaMvc.Models;

namespace AgendaMedicaMvc.Data
{
    public class AgendaMedicaMvcContext : DbContext
    {
        public AgendaMedicaMvcContext (DbContextOptions<AgendaMedicaMvcContext> options)
            : base(options)
        {
        }

        public DbSet<AgendaMedicaMvc.Models.Medico> Medico { get; set; }
    }
}
