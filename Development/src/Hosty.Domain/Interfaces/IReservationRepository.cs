using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IReservationRepository
    {
        Task AddAsync(Reservation reservation);
        Task UpdateAsync(Reservation reservation);
        Task DeleteAsync(Reservation reservation);
        Task<Reservation> GetByIdAsync(int id);
        Task<List<Reservation>> GetAllAsync();
    }
}
