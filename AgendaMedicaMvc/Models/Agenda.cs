using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AgendaMedicaMvc.Models.Enums;

namespace AgendaMedicaMvc.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public ICollection<Medico> Medico { get; set; }
        public ICollection<Paciente> Paciente { get; set; }
        //public StatusDaAgenda StatusDaAgenda { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }

        public Agenda()
        {
        }

        public Agenda(int id, DateTime date, ICollection<Medico> medico, ICollection<Paciente> paciente)
        {
            Id = id;
            Date = date;
            Medico = medico;
            Paciente = paciente;
        }
    }
}
