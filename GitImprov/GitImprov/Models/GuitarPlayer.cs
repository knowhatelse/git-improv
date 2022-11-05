using System.ComponentModel.DataAnnotations.Schema;

namespace GitImprov.Models
{
    public class GuitarPlayer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }

        [NotMapped] public string NameSurname => $"{Name} {Surname}";

        public override string ToString()
        {
            return NameSurname;
        }

    }
}
