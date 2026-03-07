using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IHotelRepository
    {
        Task AddAsync(Hotel hotel);
        Task UpdateAsync(Hotel hotel);
        Task DeleteAsync(Hotel hotel);
        Task<Hotel> GetByIdAsync(int id);
        Task<List<Hotel>> GetAllAsync();
    }
}
