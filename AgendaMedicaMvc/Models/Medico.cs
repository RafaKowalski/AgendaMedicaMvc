using System.ComponentModel.DataAnnotations;

namespace AgendaMedicaMvc.Models
{
    public class Medico
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "campo obrigatório")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Especialização")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "campo obrigatório")]
        public string Crm { get; set; }

        public Medico()
        {
        }

        public Medico(int id, string name, string specialization, string crm)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
            Crm = crm;
        }
    }
}
