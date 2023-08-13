using FirstProject.Model;
namespace FirstProject.CUI;

class Program
{
    public static void Main()
    {
        Screw s01 = new();
        Screw s02 = new();
        Bulb bulb01 = new();
        Bulb bulb02 = new();
        Screw screw03 = new();      

        List<IMerch> products = new();
        products.Add(s01);
        products.Add(s02);
        products.Add(bulb01);
        products.Add(bulb02);
        products.Add(screw03);        
        

        foreach (var current in products)
            if (current.IsExpired)
                current.TakeOffTheShelf();
    }
}