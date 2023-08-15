using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgendaMedicaMvc.Models.Enums
{
    public enum StatusDaAgenda
    {
        [Display(Name = "Agenda Confirmada")]
        AgendaConfirmada,
        [Display(Name = "Agenda Concluída")]
        AgendaConcluida,
        [Display(Name = "Agenda Cancelada")]
        AgendaCancelada
    }
}
