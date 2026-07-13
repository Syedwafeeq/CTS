namespace SOLIDPrinciplesDemo.OCP;

public static class OCPDemo
{
    public static void Run()
    {
        var calculator = new DiscountCalculator();

        decimal originalAmount = 1000m;

        IDiscountStrategy regular = new RegularCustomerDiscount();
        IDiscountStrategy premium = new PremiumCustomerDiscount();

        Console.WriteLine("Original Amount : " + originalAmount);

        Console.WriteLine(
            $"Regular Customer : {calculator.CalculateDiscount(originalAmount, regular)}"
        );

        Console.WriteLine(
            $"Premium Customer : {calculator.CalculateDiscount(originalAmount, premium)}"
        );
    }
}