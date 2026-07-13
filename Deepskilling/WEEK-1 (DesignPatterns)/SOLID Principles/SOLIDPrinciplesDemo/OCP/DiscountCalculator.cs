namespace SOLIDPrinciplesDemo.OCP;

public class DiscountCalculator
{
    public decimal CalculateDiscount(decimal amount, IDiscountStrategy strategy)
    {
        return strategy.ApplyDiscount(amount);
    }
}