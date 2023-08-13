using System.Runtime.Intrinsics;

namespace FirstProject.Model
{

    class MyClass
    {
        public int Id { get; set; }
    }

    public class Client
    {
        private const string someFieldOtherWord = "Some CONSTANT Value";
        private MyClass obj = null;
        public static string someField;

        public int A { get; private set; } = 34;
        

        public (int, int, string, string) Method()
        {
            int v1 = 5;

            //MethodReturnData result = new MethodReturnData 
            //{ V1 = v1, A = this.A, JustString = "Model.Client.Method had been called", SomeField = someFieldOtherWord };

            return (v1, this.A, "Model.Client.Method had been called", someFieldOtherWord);
        }
        public void Method01(out int ints)
        {
            ints = 0;
            for (int i = 0; i < 10; i++)
            {
                ints += Random.Shared.Next(10, 100);
            }
        }
        public void Method02(ref int ints)
        {
            ints = 0;
            for (int i = 0; i < 10; i++)
            {
                ints += Random.Shared.Next(10, 100);
            }
        }
        public int Sum(int a, int b) => a + b;

        
    }
}
namespace Data.Model
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
namespace FirstProject.Model
{
    class Person
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; }
        public int Age { get; }
        public string Address { get; }
        ///
    }
}