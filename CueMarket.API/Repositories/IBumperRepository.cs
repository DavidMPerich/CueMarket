using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface IBumperRepository
    {
        Task<List<Bumper>> GetAllAsync();
        Task<Bumper?> GetByIdAsync(Guid id);
        Task<Bumper> CreateAsync(Bumper bumper);
        Task<Bumper?> UpdateAsync(Guid id, Bumper bumper);
        Task<Bumper?> DeleteAsync(Guid id);
    }
}
