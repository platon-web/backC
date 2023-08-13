public class OrderMSSQLRepository : IOrderRepository
{
    private void Setup()
    {

    }
    public decimal GetClientSpendingsByTimePeriod(int clientId, int daysFromToday)
    {
        //real work
        return 6000m;
    }

    public List<int> GetTop3Spenders(int year, int month)
    {
        //some real work
        return new List<int>() { 34, 0, 12 };
    }
}
public class OrderMongoRepository : IOrderRepository
{
    private void Setup()
    {

    }
    public decimal GetClientSpendingsByTimePeriod(int clientId, int daysFromToday)
    {
        //real work
        return 6000m;
    }

    public List<int> GetTop3Spenders(int year, int month)
    {
        //some real work
        return new List<int>() { 34, 0, 12 };
    }
}