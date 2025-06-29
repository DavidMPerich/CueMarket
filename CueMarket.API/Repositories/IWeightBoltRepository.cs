using CueMarket.API.Models.Domain;

namespace CueMarket.API.Repositories
{
    public interface IWeightBoltRepository
    {
        Task<List<WeightBolt>> GetAllAsync();
        Task<WeightBolt?> GetByIdAsync(Guid id);
        Task<WeightBolt> CreateAsync(WeightBolt weightBolt);
        Task<WeightBolt?> UpdateAsync(Guid id, WeightBolt weightBolt);
        Task<WeightBolt?> DeleteAsync(Guid id);
    }
}
