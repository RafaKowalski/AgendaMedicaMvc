using AgendaMedicaMvc.Models;
using AgendaMedicaMvc.Models.ViewModels;
using AgendaMedicaMvc.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgendaMedicaMvc.Controllers
{
    public class RegistroDeAgendasController : Controller
    {
        private readonly RegistroDeAgendaService _registroDeAgenda;
        private readonly AgendaService _agendaService;

        public RegistroDeAgendasController(RegistroDeAgendaService registroDeAgenda, AgendaService agendaService)
        {
            _registroDeAgenda = registroDeAgenda;
            _agendaService = agendaService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _registroDeAgenda.FindAllAsync();

            return View(result);
        }

        public async Task<IActionResult> Create()
        {
            List<Agenda> agendas = await _agendaService.FindAllAgenda();
            var viewModel = new RegistroViewModel(agendas);

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegistroDeAgenda registroDeAgenda)
        {
            if (ModelState.IsValid)
            {
                await _registroDeAgenda.InsertRegistroAsync(registroDeAgenda);
                return RedirectToAction(nameof(Index));
            }
            return View(registroDeAgenda);
        }
    }
}
