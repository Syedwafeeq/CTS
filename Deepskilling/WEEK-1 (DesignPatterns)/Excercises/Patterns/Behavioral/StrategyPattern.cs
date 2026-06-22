using System;

interface IPaymentStrategy
{
    void Pay(double amount);
}

class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Credit Card");
    }
}

class UpiPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid " + amount + " using UPI");
    }
}

class PaymentContext
{
    private IPaymentStrategy strategy;

    public PaymentContext(IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ExecutePayment(double amount)
    {
        strategy.Pay(amount);
    }
}

class StrategyPattern
{
    static void Main()
    {
        PaymentContext payment =
            new PaymentContext(new UpiPayment());

        payment.ExecutePayment(500);
    }
}
