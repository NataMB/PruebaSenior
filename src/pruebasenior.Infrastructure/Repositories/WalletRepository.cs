using Microsoft.EntityFrameworkCore;
using pruebasenior.Application.Interfaces;
using pruebasenior.Domain.Entities;
using pruebasenior.Infrastructure.Data;

namespace pruebasenior.Infrastructure.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly PruebaseniorDbContext _context;

        public WalletRepository(PruebaseniorDbContext context)
        {
            _context = context;
        }

        public async Task AddTransactionAsync(WalletTransaction transaction)
        {
            _context.WalletTransactions.Add(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task<int> GetBalanceAsync(Guid userId, string programId, string pointType)
        {
            return await _context.WalletTransactions
                .Where(t => t.UserId == userId &&
                            t.ProgramId == programId &&
                            t.PointType == pointType)
                .SumAsync(t => t.Amount);
        }
    }
}