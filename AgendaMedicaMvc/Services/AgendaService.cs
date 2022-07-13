using AgendaMedicaMvc.Models;
using System.Collections.Generic;
using AgendaMedicaMvc.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace AgendaMedicaMvc.Services
{
    public class AgendaService
    {
        private readonly AgendaMedicaMvcContext _context;

        public AgendaService(AgendaMedicaMvcContext context)
        {
            _context = context;
        }

        public Task<List<Agenda>> FindAllAgenda()
        {
            return _context.Agenda.OrderBy(x => x.Date).ToListAsync();
        }
        public void InsertAgendaAsync(Agenda objAgenda)
        {
            _context.Add(objAgenda);
            _context.SaveChangesAsync();
        }

    }
}
