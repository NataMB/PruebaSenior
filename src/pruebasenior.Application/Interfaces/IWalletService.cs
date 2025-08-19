using pruebasenior.Application.DTOs;

namespace pruebasenior.Application.Interfaces
{
    public interface IWalletService
    {
        Task AccumulatePointsAsync(AccumulatePointsRequest request);

        Task<int> GetBalanceAsync(Guid userId, string programId, string pointType);
    }
}