namespace Hosty.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        IGuestRepository Guest { get; }
        IHotelRepository Hotel { get; }
        IInvoiceRepository Invoice { get; }
        IPaymentRepository Payment { get; }
        IReservationRepository Reservation { get; }
        IRoomRepository Room { get; }
        IServiceConsumptionRepository ServiceConsumption { get; }
        IServiceRepository Service { get; }
        IStayRepository Stay { get; }

        Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task<int> CommitAsync(CancellationToken cancellationToken = default);
        Task RollbackAsync(CancellationToken cancellationToken = default);
    }
}
