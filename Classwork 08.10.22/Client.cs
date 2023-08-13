using System.Runtime.CompilerServices;

namespace ConsoleApp17.Model;
public class Client
{
    private readonly string name;
    private readonly string someFieldOther = "some text";
    private int client;
    public string Method()
    {
        this.client = new();
        return "Model.Client.Method had been called";
    }
    public void Method01(out int ints)
    {
        ints = 0;
        for (int i = 0; i < 10; i++)
        {
            ints += Random.Shared.Next(10, 100);
        }
    }
    public int Sum(int a, int b) => a + b;
    //{
    //    return a+b;
    //}
}
//private
//protected
//public

//protected internal
//internal - тип даних виден только в пределах сборки в которой он определен