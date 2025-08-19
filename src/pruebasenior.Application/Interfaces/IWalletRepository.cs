 using pruebasenior.Domain.Entities;

namespace pruebasenior.Application.Interfaces
{
    public interface IWalletRepository
    {
        Task AddTransactionAsync(WalletTransaction transaction);
        Task<int> GetBalanceAsync(Guid userId, string programId, string pointType);
    }
}