using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace SuperHeroAPI.Service.Dependency
{
    public interface ISuperHeroService
    {
        public Task<List<SuperHero>> GetAll();
    }
}
