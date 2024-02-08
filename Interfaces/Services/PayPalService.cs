namespace Interfaces.Services;
class PayPalService : IPaymentService
{
    private const double FeePercentage = 0.02;
    private const double MonthlyInterest = 0.01;


    public double Interest(double amouunt, int months)
    {
        return amouunt * MonthlyInterest * months; 
    }

    public double PaymentFee(double amount)
    {
        return amount * FeePercentage;
    }
}
