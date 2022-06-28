namespace AgendaMedicaMvc.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }

        public Paciente(int id, string name, int phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
    }
}
