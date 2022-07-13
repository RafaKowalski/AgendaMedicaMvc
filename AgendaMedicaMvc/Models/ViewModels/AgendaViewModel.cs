using System.Collections.Generic;

namespace AgendaMedicaMvc.Models.ViewModels
{
    public class AgendaViewModel
    {
        public Agenda Agenda { get; set; }
        public ICollection<Medico> Medicos { get; set; }
        public ICollection<Paciente> Pacientes { get; set;}

        public AgendaViewModel(Agenda agenda, ICollection<Medico> medicos, ICollection<Paciente> pacientes)
        {
            Agenda = agenda;
            Medicos = medicos;
            Pacientes = pacientes;
        }
        public AgendaViewModel(ICollection<Medico> medicos, ICollection<Paciente> pacientes)
        {
            Medicos = medicos;
            Pacientes = pacientes;
        }
    }
}
