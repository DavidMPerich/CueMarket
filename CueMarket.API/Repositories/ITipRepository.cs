using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface ITipRepository
    {
        Task<List<Tip>> GetAllAsync();
        Task<Tip?> GetByIdAsync(Guid id);
        Task<Tip> CreateAsync(Tip tip);
        Task<Tip?> UpdateAsync(Guid id, Tip tip);
        Task<Tip?> DeleteAsync(Guid id);
    }
}
