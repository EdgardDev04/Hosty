using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IRoomTypeRepository
    {
        Task AddAsync(RoomType roomType);
        Task UpdateAsync(RoomType roomType);
        Task DeleteAsync(RoomType roomType);
        Task<RoomType> GetByIdAsync(int id);
        Task<List<RoomType>> GetAllAsync();
    }
}
