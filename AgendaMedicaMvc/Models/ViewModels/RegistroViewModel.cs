using System.Collections.Generic;

namespace AgendaMedicaMvc.Models.ViewModels
{
    public class RegistroViewModel
    {
        public RegistroDeAgenda registroDeAgenda { get; set; }
        public List<Agenda> Agendas { get; set; }

        public RegistroViewModel(List<Agenda> agendas)
        {
            Agendas = agendas;
        }

        public RegistroViewModel()
        {
        }
    }
}
