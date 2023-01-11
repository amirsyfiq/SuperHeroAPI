using SuperHeroAPI.Models;
using SuperHeroAPI.Service.Dependency;

namespace SuperHeroAPI.Service
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly DataContext _context;

        public SuperHeroService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SuperHero>> GetAll()
        {
            var resp = await _context.SuperHeroes.ToListAsync();
            return resp;
        }
    }
}
