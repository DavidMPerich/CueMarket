using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface IButtSleeveRepository
    {
        Task<List<ButtSleeve>> GetAllAsync();
        Task<ButtSleeve?> GetByIdAsync(Guid id);
        Task<ButtSleeve> CreateAsync(ButtSleeve buttSleeve);
        Task<ButtSleeve?> UpdateAsync(Guid id, ButtSleeve buttSleeve);
        Task<ButtSleeve?> DeleteAsync(Guid id);
    }
}
