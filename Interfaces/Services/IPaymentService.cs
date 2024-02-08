
namespace Interfaces.Services;
interface IPaymentService
{


    public double Interest(double amouunt, int months);

    public double PaymentFee(double amount);
}
