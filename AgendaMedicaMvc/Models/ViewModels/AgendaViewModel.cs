using AgendaMedicaMvc.Models.Enums;
using System;
using System.Collections.Generic;

namespace AgendaMedicaMvc.Models.ViewModels
{
    public class AgendaViewModel
    {
        public Agenda Agenda { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Medico> Medicos { get; set; }
        public ICollection<Paciente> Pacientes { get; set;}
        public StatusDaAgenda StatusDaAgenda { get; set; }

        public AgendaViewModel(Agenda agenda, DateTime data, ICollection<Medico> medicos, ICollection<Paciente> pacientes, StatusDaAgenda statusDaAgenda)
        {
            Agenda = agenda;
            Data = data;
            Medicos = medicos;
            Pacientes = pacientes;
            StatusDaAgenda = statusDaAgenda;
        }

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

        public AgendaViewModel(DateTime data, ICollection<Medico> medicos, ICollection<Paciente> pacientes)
        {
            Data = data;
            Medicos = medicos;
            Pacientes = pacientes;
        }
    }
}
