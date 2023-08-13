using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    using System.Diagnostics.Metrics;
    using System.Runtime.CompilerServices;

    namespace FirstProject.Model
    {
        public class Client
        {
            private static int data;
            static Client() { }
            public Client() : this("Vasia") { }
         

            public Client(string name) : this(name, 18) { }
            public Client(string name, int age)
            {
                Name = name;
                Age = age;
                Id = counter++;
            }
            public Client(Client src) : this(src.Name, src.Age) { }
           

            public string Name { get; set; }
            public int Age { get; set; }
            public int Id { get; }
            private static int counter = 1;
            public override string ToString()
            {
                return $"Name: {this.Name}\nAge: {this.Age}\nId: {this.Id}";
            }
            public static int GetSomeNumber()
            {
                return 0;
            }
        }
    }
}
