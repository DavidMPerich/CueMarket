using CueMarket.API.Models.Domain;
using Microsoft.Identity.Client;

namespace CueMarket.API.Repositories
{
    public interface ICueRepository
    {
        Task<List<Cue>> GetAllAsync(string? filterOn = null, string? filterQuery = null);
        Task<Cue?> GetByIdAsync(Guid id);
        Task<Cue> CreateAsync(Cue cue);
        Task<Cue?> UpdateAsync(Guid id, Cue cue);
        Task<Cue?> DeleteAsync(Guid id);
    }
}
