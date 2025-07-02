using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface IButtRepository
    {
        Task<List<Butt>> GetAllAsync();
        Task<Butt?> GetByIdAsync(Guid id);
        Task<Butt> CreateAsync(Butt butt);
        Task<Butt?> UpdateAsync(Guid id, Butt butt);
        Task<Butt?> DeleteAsync(Guid id);
    }
}
