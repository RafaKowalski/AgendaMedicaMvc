using System;
using AgendaMedicaMvc.Models.Enums;

namespace AgendaMedicaMvc.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Medico Medico { get; set; }
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
