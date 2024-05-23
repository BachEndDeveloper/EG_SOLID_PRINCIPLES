namespace SingleResponsebilityPrinciple;

public class Order
{
    private readonly List<(string, double)> _items = new();
    public string OrderNo { get; } = $"O-{Guid.NewGuid().ToString()}";
    public List<(string, double)> Items => _items;
    public void AddItem(string sku, double price)
    {
        _items.Add((sku, price));
        Console.WriteLine($"Item SKU {sku} added to order {OrderNo}");
    }
}

public class OrderNotificationService(EmailService emailService)
{
    public void NotifyCustomer(string to, Order order, OrderCalculator orderCalculator)
    {
     
        emailService.SendEmail("test@test.dk", 
            "Order Confirmation", 
            $"Order {order.OrderNo} has been placed. Total: {orderCalculator.CalculateTotal(order)}");
    }
}
public class EmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Sending email to {to} with subject {subject} and body {body}");
    }
}

public class OrderCalculator
{
    public double CalculateTotal(Order order)
    {
        return order.Items.Sum(s => s.Item2);
    }
}

public class OrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine($"Saving order {order.OrderNo} to database");
    }
}