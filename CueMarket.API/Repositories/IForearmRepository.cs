using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface IForearmRepository
    {
        Task<List<Forearm>> GetAllAsync();
        Task<Forearm?> GetByIdAsync(Guid id);
        Task<Forearm> CreateAsync(Forearm forearm);
        Task<Forearm?> UpdateAsync(Guid id, Forearm forearm);
        Task<Forearm?> DeleteAsync(Guid id);
    }
}
