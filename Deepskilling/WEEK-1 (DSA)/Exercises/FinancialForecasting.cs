using System;

class FinancialForecasting
{
    static double Forecast(double amount, double growthRate, int years)
    {
        if (years == 0)
            return amount;

        return Forecast(amount * (1 + growthRate), growthRate, years - 1);
    }

    static void Main()
    {
        double currentValue = 10000;
        double growthRate = 0.10;

        double futureValue = Forecast(currentValue, growthRate, 5);

        Console.WriteLine($"Future Value: {futureValue:F2}");
    }
}
