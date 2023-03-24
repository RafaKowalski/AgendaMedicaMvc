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
        public AgendaMedicaMvcContext(DbContextOptions<AgendaMedicaMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Medico> Medico { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Agenda> Agenda { get; set; }

        public DbSet<RegistroDeAgenda> RegistroDeAgenda { get; set; }
    }
}
