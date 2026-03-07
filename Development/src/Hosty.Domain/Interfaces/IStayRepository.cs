using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IStayRepository
    {
        Task AddAsync(Stay stay);
        Task UpdateAsync(Stay stay);
        Task DeleteAsync(Stay stay);
        Task<Stay> GetByIdAsync(int id);
        Task<List<Stay>> GetAllAsync();
    }
}
