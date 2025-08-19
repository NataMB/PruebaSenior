namespace pruebasenior.Application.DTOs
{
    public class BalanceResponse
    {
        public Guid UserId { get; set; }
        public string ProgramId { get; set; } = string.Empty;
        public string PointType { get; set; } = string.Empty;
        public int Balance { get; set; }
    }
}