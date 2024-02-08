
using System.Globalization;

namespace Interfaces.Entities;

class Installment
{
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }

    public Installment(DateTime dueDate, double amount)
    {
        DueDate = dueDate;
        Amount = amount;
    }

    public override string ToString()
    {
        
        return DueDate.ToString("dd/MM/yyyyy") + " - "+Amount.ToString("F2", CultureInfo.InvariantCulture);

    }
}
