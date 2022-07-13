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
        public List<Paciente> FindAllPaciente()
        {
            return _context.Paciente.OrderBy(x => x.Name).ToList();
        }
        public void InsertPacienteAsync(Paciente objPaciente)
        {
            _context.Add(objPaciente);
            _context.SaveChanges();
        }
    }
}
