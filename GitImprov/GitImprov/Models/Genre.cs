namespace GitImprov.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Type { get; set; }

        public override string ToString()
        {
            return  Type != null ? Type : string.Empty;
        }
    }
}
