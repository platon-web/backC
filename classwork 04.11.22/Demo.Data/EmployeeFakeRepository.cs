using Bogus;
using Demo.Model;
using System.Runtime.CompilerServices;

namespace Demo.Data
{
    public class EmployeeFakeRepository : IEmployeeRepository
    {
        private static List<Employee>? fakeEmployees = null;

        #region Implementation details
        private static Faker<Employee>? employeeGenerator = null;
        private static readonly string[] jobTitles =
        {
            "Computer Scientist",
            "IT Professional",
            "UX Designer & UI Developer",
            "SQL Developer",
            "Web Designer",
            "Web Developer",
            "Help Desk Worker/Desktop Support",
            "Software Engineer",
            "Data Entry",
            "DevOps Engineer",
            "Computer Programmer",
            "Network Administrator",
            "Information Security Analyst",
            "Artificial Intelligence Engineer",
            "Cloud Architect",
            "IT Manager",
            "Technical Specialist",
            "Application Developer",
            "Chief Technology Officer (CTO)",
            "Chief Information Officer (CIO)"
        };

        static EmployeeFakeRepository()
        {
            SetupEmployeeGenerator();
            GenerateRepositoryContent();
        }

        private static void GenerateRepositoryContent()
        {
            fakeEmployees = employeeGenerator?.Generate(Random.Shared.Next(60, 120));
        }

        private static void SetupEmployeeGenerator()
        {
            employeeGenerator = new Faker<Employee>()
                .RuleFor(x => x.Id, x => x.IndexGlobal)
                .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                .RuleFor(x => x.LastName, x => x.Person.LastName)
                .RuleFor(x => x.Birthday, x => DateOnly.FromDateTime(x.Person.DateOfBirth))
                .RuleFor(x => x.IsMale, x => x.Person.Gender.ToString() == "male")
                .RuleFor(x => x.JobTitle, x => x.PickRandom(jobTitles))
                .RuleFor(x => x.DepartmentId, x => x.Random.Int(1, 20))
                .RuleFor(x => x.Email, x => x.Person.Email)
                .RuleFor(x => x.PhoneNumber, x => x.Person.Phone)
                .RuleFor(x => x.BaseSalary, x => x.Random.UInt(4500, 8000));
            
        }

        #endregion

        public int? Count => fakeEmployees?.Count;

        public List<Employee> FilterBy(Predicate<Employee> pred)
        {
            return null;
        }

        public List<Employee> GetAll()
        {
            return null;
        }
    }
}