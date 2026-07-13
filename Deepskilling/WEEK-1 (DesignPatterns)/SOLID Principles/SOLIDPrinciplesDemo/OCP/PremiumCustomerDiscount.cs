namespace SOLIDPrinciplesDemo.OCP;

public class PremiumCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        return amount * 0.80m;
    }
}