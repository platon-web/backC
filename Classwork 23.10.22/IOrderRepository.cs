public interface IOrderRepository
{
    decimal GetClientSpendingsByTimePeriod(int clientId, int daysFromToday);
    List<int> GetTop3Spenders(int year, int month);
}