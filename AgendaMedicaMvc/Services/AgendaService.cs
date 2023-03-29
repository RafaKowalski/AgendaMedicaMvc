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
        private readonly Agenda _agenda;

        public AgendaService(AgendaMedicaMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Agenda>> FindAllAgenda()
        {
            return await _context.Agenda.Include(x => x.Medico).Include(x => x.Paciente).Where(x => x.Date >= DateTime.Today).OrderBy(x => x.Date).ToListAsync();
        }

        public async Task<Agenda> GetAgendaById(int? id)
        {
            return await _context.Agenda.Include(m => m.Medico).Include(p => p.Paciente).FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Agenda> InsertAgendaAsync(Agenda objAgenda)
        {
            if (objAgenda.Date < DateTime.Today)
            {
                throw new Exception("a data não pode ser menor do que a atual");
            }

            _context.Add(objAgenda);
            await _context.SaveChangesAsync();

            return objAgenda;
        }

    }
}
