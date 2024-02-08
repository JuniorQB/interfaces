using Interfaces.Entities;
using Interfaces.Services;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter contract data");
        int numerContract = int.Parse(Console.ReadLine());
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Contract value: ");
        double contractValue = double.Parse(Console.ReadLine());
        Console.Write("Enter number of installments: ");
        int numberInstallments = int.Parse(Console.ReadLine());

        Contract contract = new Contract(numerContract, date, contractValue);

        PayPalService payPalService = new PayPalService();

        ContractService contractService = new ContractService(payPalService);

        contractService.ProcessContract(contract, numberInstallments);

        foreach (Installment installment in contract.Installments) { 

            Console.WriteLine(installment);

        }

    }
}