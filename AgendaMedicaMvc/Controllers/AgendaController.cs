﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgendaMedicaMvc.Data;
using AgendaMedicaMvc.Models;
using AgendaMedicaMvc.Models.ViewModels;
using AgendaMedicaMvc.Services;

namespace AgendaMedicaMvc.Controllers
{
    public class AgendaController : Controller
    {
        private readonly AgendaMedicaMvcContext _context;
        private readonly AgendaService _agendaService;
        private readonly MedicoService _medicoService;
        private readonly PacienteService _pacienteService;

        public AgendaController(AgendaMedicaMvcContext context, AgendaService agendaService, MedicoService medicoService, PacienteService pacienteService)
        {
            _context = context;
            _agendaService = agendaService;
            _medicoService = medicoService;
            _pacienteService = pacienteService;
        }

        // GET: Agenda
        public async Task<IActionResult> Index()
        {
            return View(await _agendaService.FindAllAgenda());
        }

        // GET: Agenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _agendaService.GetAgendaById(id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // GET: Agenda/Create
        public async Task<IActionResult> Create()
        {
            List<Medico> Medicos = await _medicoService.FindAllMedico();
            List<Paciente> Pacientes = await _pacienteService.FindAllPacienteAsync();
            var viewModel = new AgendaViewModel(Medicos, Pacientes);
            return View(viewModel);
        }

        // POST: Agenda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                await _agendaService.InsertAgendaAsync(agenda);
                return RedirectToAction(nameof(Index));
            }
            return View(agenda);
        }

        // GET: Agenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _agendaService.GetAgendaById(id.Value);
            if (agenda == null)
            {
                return NotFound();
            }

            List<Medico> Medicos = await _medicoService.FindAllMedico();
            List<Paciente> Pacientes = await _pacienteService.FindAllPacienteAsync();
            var viewModel = new AgendaViewModel(agenda, Medicos, Pacientes);

            return View(viewModel);
        }

        // POST: Agenda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Agenda agenda)
        {
            if (id != agenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendaExists(agenda.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            List<Medico> Medicos = await _medicoService.FindAllMedico();
            List<Paciente> Pacientes = await _pacienteService.FindAllPacienteAsync();
            var viewModel = new AgendaViewModel(agenda, Medicos, Pacientes);

            return View(viewModel);
        }

        // GET: Agenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agenda = await _context.Agenda.Include(m => m.Medico).Include(p => p.Paciente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (agenda == null)
            {
                return NotFound();
            }

            return View(agenda);
        }

        // POST: Agenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agenda = await _context.Agenda.FindAsync(id);
            _context.Agenda.Remove(agenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendaExists(int id)
        {
            return _context.Agenda.Any(e => e.Id == id);
        }
    }
}
