using AgendaMedicaMvc.Models.Enums;
using System;

namespace AgendaMedicaMvc.Models
{
    public class RegistroDeAgenda
    {
        public Guid Id { get; set; }
        public Agenda Agenda { get; set; }
        public StatusDaAgenda StatusDaAgenda { get; set; }
        public int AgendaId { get; set; }
    }
}
