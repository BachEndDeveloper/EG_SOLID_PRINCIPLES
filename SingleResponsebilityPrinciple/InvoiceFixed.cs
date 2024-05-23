namespace SingleResponsebilityPrinciple;

// public class InvoiceFixed
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