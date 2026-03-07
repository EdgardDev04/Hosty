using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IServiceConsumptionRepository
    {
        Task AddAsync(ServiceConsumption consumption);
        Task UpdateAsync(ServiceConsumption consumption);
        Task DeleteAsync(ServiceConsumption consumption);
        Task<ServiceConsumption> GetByIdAsync(int id);
        Task<List<ServiceConsumption>> GetAllAsync();
    }
}
