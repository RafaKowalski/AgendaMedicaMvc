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
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        //public StatusDaAgenda StatusDaAgenda { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }

        public Agenda()
        {
        }

        public Agenda(int id, DateTime date, Medico medico, Paciente paciente)
        {
            Id = id;
            Date = date;
            Medico = medico;
            Paciente = paciente;
        }

        public Agenda(DateTime date)
        {
            Date = date;
        }
    }
}
