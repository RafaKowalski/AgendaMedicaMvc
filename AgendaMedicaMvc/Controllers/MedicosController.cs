using Microsoft.AspNetCore.Mvc;
using AgendaMedicaMvc.Models;
using System.Collections.Generic;

namespace AgendaMedicaMvc.Controllers
{
    public class MedicosController : Controller
    {
        public IActionResult Index()
        {
            List<Medico> medico = new List<Medico>();
            medico.Add(new Medico(1, "Medico Teste", "Cirurgião Plastico"));
            return View(medico);
        }
    }
}
