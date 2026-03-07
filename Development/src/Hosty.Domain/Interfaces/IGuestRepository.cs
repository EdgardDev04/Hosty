using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IGuestRepository
    {
        Task AddAsync(Guest guest);
        Task UpdateAsync(Guest guest);
        Task DeleteAsync(Guest guest);
        Task<Guest> GetByIdAsync(int id);
        Task<List<Guest>> GetAllAsync();

    }
}
