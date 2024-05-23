namespace SingleResponsebilityPrinciple;

public class Invoice
{
    public double GetInvoiceDiscount(InvoiceType invoice) =>
        invoice switch
        {
            InvoiceType.OneTime => 0.1,
            InvoiceType.Recurring => 0.2,
            InvoiceType.TopCustomer => 0.3,
            _ => 0
        };

    public double GetTotal(double total, InvoiceType invoice)
    {
        return total - GetInvoiceDiscount(invoice);
    }
}

public enum InvoiceType
{
    OneTime,
    Recurring,
    TopCustomer
}

#region O - Open/Closed Principle

// public class Invoice
// {
//     public virtual double GetInvoiceDiscount() => 0;
//
//     public double GetTotal(double total)
//     {
//         return total - GetInvoiceDiscount();
//     }
// }
//
// public class OneTimeInvoice : Invoice
// {
//     public override double GetInvoiceDiscount() => 1.0;
// }
//
// public class RecurringInvoice : Invoice
// {
//     public override double GetInvoiceDiscount() => 2.0;
// }
//
// public class TopCustomerInvoice : Invoice
// {
//     public override double GetInvoiceDiscount() => 3.0;
// }

#endregion