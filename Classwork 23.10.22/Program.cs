using System;
using FirstProject.BL;
using FirstProject.Model;
namespace FirstProject.CUI;

class Program
{
    public static void Main()
    {
        //OrderMSSQLRepository orderMSSQLRepository = new();
        //OrderMongoRepository orderMongoRepository = new();
        FakeOrderRepository fakeOrderRepository = new();
        //DiscountRuleEngine discountRuleEngine = new(orderMSSQLRepository);
        //DiscountRuleEngine discountRuleEngine1 = new(new OrderMongoRepository());
        //DiscountRuleEngine dre = new(orderMSSQLRepository, orderMongoRepository);
        //decimal discount = discountRuleEngine.CalculateDiscount(0);
        Client c = new();
        Rules engine = new(fakeOrderRepository);
        int result = engine.Calculate(c);
        Console.WriteLine( result );
    }
}