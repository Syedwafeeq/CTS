namespace SOLIDPrinciplesDemo.OCP;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal amount);
}