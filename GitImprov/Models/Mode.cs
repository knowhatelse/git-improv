namespace GitImprov.Models
{
    public class Mode
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }

        public string ActiveText => Active ? "Yes" : "No";
    }
}
