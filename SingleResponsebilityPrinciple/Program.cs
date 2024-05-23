// See https://aka.ms/new-console-template for more information

using SingleResponsebilityPrinciple;

// Console.WriteLine("Example of the Single Responsibility Principle");
// Order o1 = new();
//
// o1.AddItem("123", 12.99);
// o1.AddItem("456", 1993.00);
// o1.AddItem("789", 0.99);

// Console.WriteLine("Example of the Open/Closed Principle");
//
// Invoice i = new Invoice();
//
// Console.WriteLine($"One time payment invoice {i.GetTotal(100, InvoiceType.OneTime)}");
// Console.WriteLine($"Recurring payment invoice {i.GetTotal(100, InvoiceType.Recurring)}");
// Console.WriteLine($"Top Customer payment invoice {i.GetTotal(100, InvoiceType.TopCustomer)}");


#region O - Open/Closed Principle fixed

// Console.WriteLine(normal.GetTotal(100));
// Console.WriteLine(oneTime.GetTotal(100));
// Console.WriteLine(recurring.GetTotal(100));
// Console.WriteLine(topCustomer.GetTotal(100));

#endregion

Console.WriteLine("The Liskov substitution principle");

Fruit apple =  new Apple();

Fruit orange = new Orange();

Console.WriteLine($"The apple is {apple.GetColor()}");
Console.WriteLine($"The orange is {orange.GetColor()}");