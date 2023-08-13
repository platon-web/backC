using Demo.Model;

namespace Demo.Data
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        List<Employee> FilterBy(Predicate<Employee> pred);
    }
}
