using Swashbuckle.AspNetCore.Filters;
using pruebasenior.Application.DTOs;

namespace pruebasenior.API.SwaggerExamples
{
    public class AccumulatePointsRequestExample : IExamplesProvider<AccumulatePointsRequest>
    {
        public AccumulatePointsRequest GetExamples()
        {
            return new AccumulatePointsRequest
            {
                UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                ProgramId = "LOYALTY_2025",
                PointType = "PUNTOS",
                Amount = 100
            };
        }
    }
}