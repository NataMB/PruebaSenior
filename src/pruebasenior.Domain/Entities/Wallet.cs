namespace pruebasenior.Domain.Entities;

public class Wallet
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public string ProgramId { get; set; } = default!; 
    public Dictionary<string, decimal> Balances { get; set; } = new();
}