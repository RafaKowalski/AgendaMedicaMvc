using System.ComponentModel.DataAnnotations;

namespace AgendaMedicaMvc.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public long Phone { get; set; }

        public Paciente()
        {
        }

        public Paciente(int id, string name, string email, long phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
