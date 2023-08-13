namespace Homework.Classes
{
    public class Shop
    {
        public string name { get; set; }
        public string exposition { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public ulong number { get; set; }
        public bool Enter(string name, string exposition, string address, string email, int year, int num)
        {
            this.name = name;
            this.exposition = exposition;
            this.address = address;
            number = num;
            this.email = email;
            return true;
        }
        public bool Print()
        {
            if (name == null)
                return false;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Exposition: {exposition}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone number: {number:+##(###)###-##-##}");
            Console.WriteLine($"Email: {email}");
            return true;
        }
    }
}