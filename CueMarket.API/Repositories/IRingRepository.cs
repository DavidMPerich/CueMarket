using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface IRingRepository
    {
        Task<List<Ring>> GetAllAsync();
        Task<Ring?> GetByIdAsync(Guid id);
        Task<Ring> CreateAsync(Ring ring);
        Task<Ring?> UpdateAsync(Guid id, Ring ring);
        Task<Ring?> DeleteAsync(Guid id);
    }
}
