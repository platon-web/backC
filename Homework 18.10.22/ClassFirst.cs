namespace ConsoleApp25.Class
{
    public class Magazine
    {
        private string name;
        private string exposition;
        private string email;
        private int yearCreate;
        private int number;
        public bool Enter(string name, string exposition, string email, int yearCreate, int phoneNum)
        {
            this.name = name;
            this.exposition = exposition;
            this.email = email;
            this.yearCreate = yearCreate;
            this.number = phoneNum;
            return true;
        }
        public bool Print()
        {
            if (name == null)
                return false;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Exposition: {exposition}");
            Console.WriteLine($"Phone number: {number:+##(###)###-##-##}");
            Console.WriteLine($"email: {email}");
            Console.WriteLine($"Year of create: {yearCreate}");
            return true;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public string GetName()
        {
            return name;
        }
        public void SetExposition(string value)
        {
            exposition = value;
        }
        public string GetExposition()
        {
            return exposition;
        }
        public void SetEmail(string value)
        {
            email = value;
        }
        public string GetEMail()
        {
            return email;
        }
        public void SetYearOfCreate(ushort value)
        {
            yearCreate = value;
        }
        public int GetYearOfCreate()
        {
            return yearCreate;
        }
        public void SetNumber(ulong value)
        {
            number = value;
        }
        public int GetNumber()
        {
            return number;
        }
    }
}