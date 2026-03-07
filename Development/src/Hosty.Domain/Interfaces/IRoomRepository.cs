using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IRoomRepository
    {
        Task AddAsync(Room room);
        Task UpdateAsync(Room room);
        Task DeleteAsync(Room room);
        Task<Room> GetByIdAsync(int id);
        Task<List<Room>> GetAllAsync();
    }
}
