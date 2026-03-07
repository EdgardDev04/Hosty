using Hosty.Domain.Entities;

namespace Hosty.Domain.Interfaces
{
    public interface IInvoiceRepository
    {
        Task AddAsync(Invoice invoice);
        Task UpdateAsync(Invoice invoice);
        Task DeleteAsync(Invoice invoice);
        Task<Invoice> GetByIdAsync(int id);
        Task<List<Invoice>> GetAllAsync();
    }
}
