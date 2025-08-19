using pruebasenior.Application.DTOs;
using pruebasenior.Application.Interfaces;
using pruebasenior.Domain.Entities;

namespace pruebasenior.Application.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;

        public WalletService(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public async Task AccumulatePointsAsync(AccumulatePointsRequest request)
        {
            var transaction = new WalletTransaction
            {
                UserId = request.UserId,
                ProgramId = request.ProgramId,
                PointType = request.PointType,
                Amount = request.Amount,
                OperationType = "ACCUMULATE"
            };

            await _walletRepository.AddTransactionAsync(transaction);
        }

        public async Task<int> GetBalanceAsync(Guid userId, string programId, string pointType)
        {
            return await _walletRepository.GetBalanceAsync(userId, programId, pointType);
        }
    }
}