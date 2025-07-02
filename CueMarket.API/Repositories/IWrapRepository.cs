using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface IWrapRepository
    {
        Task<List<Wrap>> GetAllAsync();
        Task<Wrap?> GetByIdAsync(Guid id);
        Task<Wrap> CreateAsync(Wrap wrap);
        Task<Wrap?> UpdateAsync(Guid id, Wrap wrap);
        Task<Wrap?> DeleteAsync(Guid id);
    }
}
