namespace Homework.home
{
    public class Shop
    {
        public string Name { get; set; }
        public string Exposition { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
        public ulong number { get; set; }
        public bool Enter(string name, string exposition, string address, string Email,  ulong phoneNum)
        {
            Name = name;
            Exposition = exposition;
            Address = address;
            number = phoneNum;
            email = Email;
            return true;
        }
        public bool Print()
        {
            if (Name == null)
                return false;
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Exposition: {Exposition}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone number: {number:+##(###)###-##-##}");
            Console.WriteLine($"Email: {email}");
            return true;
        }
    }
}