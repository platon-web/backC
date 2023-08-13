
using System;
Dictionary<int, List<Person>> employees = new();

employees.Add(34, new List<Person>());

employees[34].Add(new Person() {​​​​​ FirstName = "Vasia" }​​​​​);

employees[34].Add(new Person() {​​​​​ FirstName = "Petia" }​​​​​);

employees[34].Add(new Person() {​​​​​ FirstName = "Olia" }​​​​​);

employees[34].Add(new Person() {​​​​​ FirstName = "Vanya" }​​​​​);

employees.Add(72, new List<Person>());

employees[72].Add(new Person() {​​​​​ FirstName = "Roman" }​​​​​);

employees[72].Add(new Person() {​​​​​ FirstName = "Victoria" }​​​​​);

employees.Add(12, employees[72]);

employees[72] = new List<Person>();

employees[72].Add(new Person() {​​​​​ FirstName = "Sergei" }​​​​​);

employees[72].Add(new Person() {​​​​​ FirstName = "Alexander" }​​​​​); foreach (var c in employees[34])

    global::System.Console.WriteLine(c.FirstName);

employees[34][1].Address = ""; 
class Person
{​​​​​

    public string FirstName {​​​​​ get; set; }​​​​​

    public string LastName {​​​​​ get; set; }​​​​​

    public string Address {​​​​​ get; set; }​​​​​

}​​​​​

