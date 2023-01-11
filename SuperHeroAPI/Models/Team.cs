namespace SuperHeroAPI.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;

        // Relation with Table SuperHeroes
        public List<SuperHero> superHeroes { get; set; } 
    }
}
