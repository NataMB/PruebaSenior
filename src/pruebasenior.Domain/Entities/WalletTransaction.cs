namespace pruebasenior.Domain.Entities
{
    public class WalletTransaction
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public string ProgramId { get; set; } = string.Empty;
        public string PointType { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string OperationType { get; set; } = "ACCUMULATE"; 
    }
}