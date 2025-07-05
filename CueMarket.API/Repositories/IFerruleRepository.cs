using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface IFerruleRepository
    {
        Task<List<Ferrule>> GetAllAsync();
        Task<Ferrule?> GetByIdAsync(Guid id);
        Task<Ferrule> CreateAsync(Ferrule ferrule);
        Task<Ferrule?> UpdateAsync(Guid id, Ferrule ferrule);
        Task<Ferrule?> DeleteAsync(Guid id);
    }
}
