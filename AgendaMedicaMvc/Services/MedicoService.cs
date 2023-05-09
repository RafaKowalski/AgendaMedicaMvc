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

        public async Task<List<Medico>> FindAllMedico()
        {
            return await _context.Medico.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Medico> FindMedicoById(int? id)
        {
            return await _context.Medico.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Medico> InsertMedicoAsync(Medico objMedico)
        {
            _context.Add(objMedico);
            await _context.SaveChangesAsync();

            return objMedico;
        }

        public async Task<Medico> EditMedico(Medico medico)
        {
            _context.Update(medico);
            await _context.SaveChangesAsync();

            return medico;
        }

        public async Task DeleteMedico(Medico medico)
        {
            _context.Medico.Remove(medico);
            await _context.SaveChangesAsync();
        }
    }
}
