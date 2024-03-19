namespace GitImprov.Models
{
    public class BackingTrack
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public bool Active { get; set; }

        public string ActiveText => Active ? "Yes" : "No";
    }
}
