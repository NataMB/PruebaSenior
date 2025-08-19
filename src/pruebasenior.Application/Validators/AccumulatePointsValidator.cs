using FluentValidation;
using pruebasenior.Application.DTOs;

namespace pruebasenior.Application.Validators;

public class AccumulatePointsValidator : AbstractValidator<AccumulatePointsRequest>
{
    public AccumulatePointsValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.ProgramId).NotEmpty();
        RuleFor(x => x.PointType).NotEmpty();
        RuleFor(x => x.Amount).GreaterThan(0);
    }
}