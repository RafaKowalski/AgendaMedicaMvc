using AgendaMedicaMvc.Data;
using AgendaMedicaMvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaMedicaMvc.Services
{
    public class PacienteService
    {
        private readonly AgendaMedicaMvcContext _context;

        public PacienteService(AgendaMedicaMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Paciente>> FindAllPacienteAsync()
        {
            return await _context.Paciente.OrderBy(x => x.Name).ToListAsync();
        }
        public async Task<Paciente> FindPacienteById(int? id)
        {
            return await _context.Paciente.FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task InsertPacienteAsync(Paciente objPaciente)
        {
            _context.Add(objPaciente);
            await _context.SaveChangesAsync();
        }

        public async Task<Paciente> EditPaciente(Paciente paciente)
        {
            _context.Update(paciente);
            await _context.SaveChangesAsync();

            return paciente;
        }

        public async Task DeletePaciente(Paciente paciente)
        {
            _context.Paciente.Remove(paciente);
            await _context.SaveChangesAsync();
        }
    }
}
