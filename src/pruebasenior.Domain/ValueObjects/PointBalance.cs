namespace pruebasenior.Domain.ValueObjects;

public class PointBalance
{
    public string PointType { get; private set; }
    public decimal Amount { get; private set; }

    public PointBalance(string pointType, decimal amount)
    {
        if (string.IsNullOrWhiteSpace(pointType))
            throw new ArgumentException("Point type cannot be empty");

        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative");

        PointType = pointType;
        Amount = amount;
    }
}