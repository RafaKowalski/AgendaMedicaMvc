using AgendaMedicaMvc.Models;
using System.Collections.Generic;
using AgendaMedicaMvc.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgendaMedicaMvc.Services
{
    public class AgendaService
    {
        private readonly AgendaMedicaMvcContext _context;

        public AgendaService(AgendaMedicaMvcContext context)
        {
            _context = context;
        }

        public Task<List<Medico>> FindAllMedico()
        {
            return _context.Medico.ToListAsync();
        }
        public Task<List<Paciente>> FindAllPaciente()
        {
            return _context.Paciente.ToListAsync();
        }

        public async Task InsertMedicoAsync(Medico objMedico)
        {
            _context.Add(objMedico);
            _context.SaveChangesAsync();
        }

        public async Task InsertPacienteAsync(Paciente objPaciente)
        {
            _context.Add(objPaciente);
            _context.SaveChanges();
        }
    }
}
