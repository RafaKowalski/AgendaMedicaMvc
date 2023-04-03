﻿using AgendaMedicaMvc.Data;
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
        public async Task InsertPacienteAsync(Paciente objPaciente)
        {
            _context.Add(objPaciente);
            await _context.SaveChangesAsync();
        }
    }
}
