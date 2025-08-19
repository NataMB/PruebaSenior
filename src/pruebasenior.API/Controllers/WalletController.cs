using Microsoft.AspNetCore.Mvc;
using pruebasenior.Application.DTOs;
using pruebasenior.Application.Interfaces;

namespace pruebasenior.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WalletController : ControllerBase
    {
        private readonly IWalletService _walletService;

        public WalletController(IWalletService walletService)
        {
            _walletService = walletService;
        }

        [HttpPost("accumulate")]
        public async Task<IActionResult> Accumulate([FromBody] AccumulatePointsRequest request)
        {
            await _walletService.AccumulatePointsAsync(request);
            return Ok("Points accumulated successfully");
        }

        [HttpGet("{userId}/balance")]
        public async Task<ActionResult<BalanceResponse>> GetBalance(Guid userId, [FromQuery] string programId, [FromQuery] string pointType)
        {
            var balance = await _walletService.GetBalanceAsync(userId, programId, pointType);

            return Ok(new BalanceResponse
            {
                UserId = userId,
                ProgramId = programId,
                PointType = pointType,
                Balance = balance
            });
        }
    }
}