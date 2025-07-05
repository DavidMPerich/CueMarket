using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface IShaftRepository
    {
        Task<List<Shaft>> GetAllAsync();
        Task<Shaft?> GetByIdAsync(Guid id);
        Task<Shaft> CreateAsync(Shaft shaft);
        Task<Shaft?> UpdateAsync(Guid id, Shaft shaft);
        Task<Shaft?> DeleteAsync(Guid id);
    }
}
