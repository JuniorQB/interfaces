
using Interfaces.Entities;

namespace Interfaces.Services;
class ContractService
{
    private IPaymentService paymentService;

    public ContractService(IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }


    public void ProcessContract(Contract contract, int months)
    {
        double basicQuota = contract.TotalValue / months;

        for (int i = 1; i <= months; i++)
        {
            DateTime date = contract.Date.AddMonths(i);
            double updateQuota = basicQuota + paymentService.Interest(basicQuota, i);
            double fullQuota = updateQuota + paymentService.PaymentFee(updateQuota);
            contract.AddInstallment(new Installment(date, fullQuota));

        }
    }
}
