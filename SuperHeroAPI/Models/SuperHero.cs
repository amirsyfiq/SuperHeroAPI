namespace SuperHeroAPI.Models
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        
        // Relation with Table Teams
        public int? TeamsId { get; set; }

        public Team?  Teams { get; set; }
    }
}
