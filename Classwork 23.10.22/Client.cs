namespace FirstProject.Model;
public class PhoneNumber
{

}

public class Address
{
    public int Id { get; }
}

public class Client
{
    public int Id { get; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public List<PhoneNumber>? PhoneNumber { get; set; }
    public List<Address>? Address { get; set; }
    public bool Validate()
    {
        return true;
    }
}

public class Product
{
    public int Id { get; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    //
    //
    //
    //
    public decimal Price { get; set; }
}

public class OrderItem
{
    public Product? Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; }
}

public class Order
{
    public int Id { get; }
    public Client Client { get; }
    public DateTime OrderDate { get; }
    public Address DeliveryAddress { get; set; }
    public List<OrderItem> OrderItems { get; }
    public DiscountRuleEngine? rules;

    public Order(Client client, DiscountRuleEngine discountEngine)
    {
        this.Client = client;
        this.OrderDate = DateTime.Now;
        this.rules = discountEngine;
    }    

    public decimal GetOrderPrice()
    {
        decimal total = 0m;
        foreach (var current in this.OrderItems)
            total += current.Price;
        total *= this.rules!.CalculateDiscount(this.Client.Id);
        return total;
    }
}

public class  FakeOrderRepository : IOrderRepository
{
    public decimal GetClientSpendingsByTimePeriod(int clientId, int daysFromToday)
    {
        return 6000m;
    }

    public List<int> GetTop3Spenders(int year, int month)
    {
        return new List<int>() { 34, 0, 12 };
    }
}

public class DiscountRuleEngine
{
    private IOrderRepository? orderRepository;
    public DiscountRuleEngine(IOrderRepository repo)
    {
        this.orderRepository = repo;
    }
    public DiscountRuleEngine(IOrderRepository repo, IOrderRepository repo1)
    {
        this.orderRepository = repo;
    }
    public decimal CalculateDiscount(int clientId)
    {
        decimal clientSpendings = orderRepository!.GetClientSpendingsByTimePeriod(clientId, 20);
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month - 1;
        List<int> top3 = orderRepository!.GetTop3Spenders(year, month);
        return 0.9m;
    }
} 