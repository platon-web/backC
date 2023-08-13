using FirstProject.Model;

namespace FirstProject.BL;
public interface IRule
{
    bool Eligible(Client client);
    int Value { get; }
}
public class Rules
{
    List<IRule> allExtremumRules = new();
    List<IRule> allAdditiveRules = new();
    public Rules(IOrderRepository orderRepository)
    {
        //extrem
        allExtremumRules.Add(new RuleA(orderRepository));
        allExtremumRules.Add(new RuleB(orderRepository));
        allExtremumRules.Add(new RuleC(orderRepository));
        //additive
        allAdditiveRules.Add(new RuleD(orderRepository));
    }
    public int Calculate(Client client)
    {
        int discount = 0;
        foreach (var rule in allExtremumRules)
        {
            if(rule.Eligible(client))
                discount = Math.Max(discount, rule.Value);
        }
        foreach (var rule in allAdditiveRules)
        {
            if (rule.Eligible(client))
                discount += rule.Value;
        }
        return discount;
    }
}

//10% 2000
public class RuleA : IRule
{
    private readonly IOrderRepository repo;
    public RuleA(IOrderRepository repo)
    {
        this.repo = repo;
    }

    public int Value => 10;

    public bool Eligible(Client client)
    {
        return true;
    }
}
//30% 8000
public class RuleB : IRule
{
    private readonly IOrderRepository repo;
    public RuleB(IOrderRepository repo)
    {
        this.repo = repo;
    }

    public int Value => 30;

    public bool Eligible(Client client)
    {
        throw new NotImplementedException();
    }
}
//20% 6000
public class RuleC : IRule
{
    private readonly IOrderRepository repo;
    public RuleC(IOrderRepository repo)
    {
        this.repo = repo;
    }

    public int Value => 20;

    public bool Eligible(Client client)
    {
        throw new NotImplementedException();
    }
}

//adds 6% birthday
public class RuleD : IRule
{
    private readonly IOrderRepository repo;
    public RuleD(IOrderRepository repo)
    {
        this.repo = repo;
    }

    public int Value => 6;

    public bool Eligible(Client client)
    {
        throw new NotImplementedException();
    }
}
