namespace AgendaMedicaMvc.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
