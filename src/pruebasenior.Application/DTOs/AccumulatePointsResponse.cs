namespace pruebasenior.Application.DTOs;

public class AccumulatePointsResponse
{
    public Guid TransactionId { get; set; }
    public Guid UserId { get; set; }
    public string ProgramId { get; set; } = default!;
    public string PointType { get; set; } = default!;
    public decimal NewBalance { get; set; }
}