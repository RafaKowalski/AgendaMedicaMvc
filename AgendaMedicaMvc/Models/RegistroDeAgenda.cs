using AgendaMedicaMvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace AgendaMedicaMvc.Models
{
    public class RegistroDeAgenda
    {
        public Guid Id { get; set; }
        public Agenda Agenda { get; set; }
        [Display(Name = "Status")]
        public StatusDaAgenda StatusDaAgenda { get; set; }
        public int AgendaId { get; set; }
    }
}
