using System.ComponentModel.DataAnnotations;

namespace pruebasenior.Application.DTOs
{
    public class AccumulatePointsRequest
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string ProgramId { get; set; } = default!;

        [Required]
        public string PointType { get; set; } = default!;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount must be greater than zero")]
        public int Amount { get; set; }
    }
}