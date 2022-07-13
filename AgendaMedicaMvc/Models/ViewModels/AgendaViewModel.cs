using System.Collections.Generic;

namespace AgendaMedicaMvc.Models.ViewModels
{
    public class AgendaViewModel
    {
        public Agenda Agenda { get; set; }
        public ICollection<Medico> Medicos { get; set; }
        public ICollection<Paciente> Pacientes { get; set;}
    }
}
