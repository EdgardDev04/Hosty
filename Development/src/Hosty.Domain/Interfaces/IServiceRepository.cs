using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IServiceRepository
    {
        Task AddAsync(Service service);
        Task UpdateAsync(Service service);
        Task DeleteAsync(Service service);
        Task<Service> GetByIdAsync(int id);
        Task<List<Service>> GetAllAsync();
    }
}
