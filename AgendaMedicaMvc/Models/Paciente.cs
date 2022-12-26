using System.ComponentModel.DataAnnotations;

namespace AgendaMedicaMvc.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public int Phone { get; set; }
        public string Observacao { get; set; }

        public Paciente()
        {
        }

        public Paciente(int id, string name, string email, int phone, string observacao)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Observacao = observacao;
        }
    }
}
