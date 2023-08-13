Dictionary<long, Person> employees = new();
employees.Add(6936438771, new Person() { FirstName = "Вася", LastName = "Пупкин", Address = "Some place on Earth" });
employees.Add(7363141011, new Person() { FirstName = "Петя", LastName = "Васечкин", Address = "Some place on Earth" });

employees.ContainsKey(7363141011);
employees.ContainsValue(new Person() { FirstName = "Вася", LastName = "Пупкин", Address = "Some place on Earth" });

employees[6936438771] = new Person() { FirstName = "Оля", LastName = ...};
employees[6936438771].LastName = "NewLastName";

Console.WriteLine(employees[6936438771]);


foreach (var (key, value) in employees)
{
    Console.WriteLine($"Id: {key} FirsName: {value.FirstName} LastName: {value.LastName} Address: {value.Address}");
}


class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}