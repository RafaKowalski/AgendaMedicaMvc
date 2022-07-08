using System;
using System.ComponentModel.DataAnnotations;
using AgendaMedicaMvc.Models.Enums;

namespace AgendaMedicaMvc.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0:f")]
        public DateTime Date { get; set; }
        [Required]
        public Medico Medico { get; set; }
        [Required]
        public Paciente Paciente { get; set; }
        public StatusDaAgenda StatusDaAgenda { get; set; }

        public Agenda()
        {
        }
        public Agenda(int id, DateTime date, Medico medico, Paciente paciente, StatusDaAgenda statusDaAgenda)
        {
            Id = id;
            Date = date;
            Medico = medico;
            Paciente = paciente;
            StatusDaAgenda = statusDaAgenda;
        }
    }
}
