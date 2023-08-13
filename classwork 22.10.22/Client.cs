namespace FirstProject.Model;


public enum Material
{
    None = 0,
    Steel = 1,
    Aluminium = 2
}

public interface IMerch
{
    int Id { get;  }
    string? Name { get; set; }
    bool IsExpired { get; }
    bool TakeOffTheShelf();
}

public class Screw : IMerch
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Material Material { get; set; }
    public double ScrewStep { get; set; }
    public double Weight { get; set; }
    public bool IsExpired { get; }

    public bool TakeOffTheShelf()
    {
        return false;
    }
}

public class Bulb : IMerch
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Power { get; set; }
    public int LightTemperature { get; set; }
    public int CapType { get; set; }
    public bool IsExpired { get; }

    public bool TakeOffTheShelf()
    {
        return true;
    }
}

public class Glue : IMerch
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsExpired { get;  }

    public bool TakeOffTheShelf()
    {
        return true;
    }
}

