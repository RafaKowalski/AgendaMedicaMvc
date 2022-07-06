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

        public Medico()
        {
        }

        public Medico(int id, string name, string specialization)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
        }
    }
}
