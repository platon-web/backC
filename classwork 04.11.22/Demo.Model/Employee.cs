namespace Demo.Model
{
    public class Employee
    {
        public int Id { get; private set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly? Birthday { get; set; }
        public bool IsMale { get; set; }
        public string? JobTitle { get; set; }
        public int? DepartmentId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal? BaseSalary { get; set; }

        public override string ToString()
        {
            return $"{Id}: {LastName} {FirstName}, {JobTitle} at dep [{DepartmentId}], phone: {PhoneNumber}, email: {Email}";
        }
    }
}