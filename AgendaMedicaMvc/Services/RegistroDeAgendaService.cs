using AgendaMedicaMvc.Data;
using AgendaMedicaMvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaMedicaMvc.Services
{
    public class RegistroDeAgendaService
    {
        private readonly AgendaMedicaMvcContext _context;

        public RegistroDeAgendaService(AgendaMedicaMvcContext context)
        {
            _context = context;
        }

        public async Task<List<RegistroDeAgenda>> FindAllAsync()
        {
            return await _context.RegistroDeAgenda.Include(a => a.Agenda).OrderBy(x => x.Agenda.Date).ToListAsync();
        }

        public async Task<RegistroDeAgenda> InsertRegistroAsync(RegistroDeAgenda registroDeAgenda)
        {
            _context.Add(registroDeAgenda);
            await _context.SaveChangesAsync();

            return registroDeAgenda;
        }
    }
}
