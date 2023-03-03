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
            return _context.Agenda.Include(x => x.Medico).Include(x => x.Paciente).OrderBy(x => x.Date).ToListAsync();
        }

        public async Task<Agenda> GetAgendaById(int? id)
        {
            return await _context.Agenda.Include(m => m.Medico).Include(p => p.Paciente).FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Agenda> InsertAgendaAsync(Agenda objAgenda)
        {
            _context.Add(objAgenda);
            _context.SaveChangesAsync();

            return objAgenda;
        }

    }
}
