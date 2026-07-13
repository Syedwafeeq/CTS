namespace SOLIDPrinciplesDemo.OCP;

public class RegularCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        return amount * 0.90m;
    }
}