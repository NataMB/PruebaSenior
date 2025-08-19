namespace pruebasenior.Domain.Entities;

public enum TransactionType
{
    Accumulate,
    Redeem
}

public class Transaction
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public string ProgramId { get; set; } = default!;
    public string PointType { get; set; } = default!;
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}