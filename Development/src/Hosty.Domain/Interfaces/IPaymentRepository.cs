using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IPaymentRepository
    {
        Task AddAsync(Payment payment);
        Task UpdateAsync(Payment payment);
        Task DeleteAsync(Payment payment);
        Task<Payment> GetByIdAsync(int id);
        Task<List<Payment>> GetAllAsync();
    }
}
