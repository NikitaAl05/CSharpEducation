namespace Practice3.Task10;

class Automobile
{
    private string brand;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public Automobile(string brand)
    {
        Brand = brand;
    }

    public void GetInfoBrand(Automobile auto)
    {
        Console.WriteLine(auto.Brand);
    }
}