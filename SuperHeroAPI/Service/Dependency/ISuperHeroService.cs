using Microsoft.Extensions.Diagnostics.HealthChecks;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Service.Dependency
{
    public interface ISuperHeroService
    {
        public Task<List<SuperHero>> GetAll();
    }
}
