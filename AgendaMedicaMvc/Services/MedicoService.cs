using AgendaMedicaMvc.Data;
using AgendaMedicaMvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaMedicaMvc.Services
{
    public class MedicoService
    {
        private readonly AgendaMedicaMvcContext _context;

        public MedicoService(AgendaMedicaMvcContext context)
        {
            _context = context;
        }

        public List<Medico> FindAllMedico()
        {
            return _context.Medico.OrderBy(x => x.Name).ToList();
        }
        public async Task InsertMedicoAsync(Medico objMedico)
        {
            _context.Add(objMedico);
            await _context.SaveChangesAsync();
        }
    }
}
