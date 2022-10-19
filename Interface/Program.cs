River river = new River();
river.name = "Dnipro";

interface IGeographicalObject
{
    decimal x { get; }
    decimal y { get; }
    string name { get; }
    string description { get; }
    public void GetInfo();
    
}


class River : IGeographicalObject
{
    public decimal x { get; set; }
    public decimal y { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public double speed { get; set; }
    public double length { get; set; }
    public void GetInfo() 
    {
        Console.WriteLine(description);
    }
}

class Mountain : IGeographicalObject
{
    public decimal x { get; set; }
    public decimal y { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public double peak { get; set; }
    public void GetInfo()
    {
        Console.WriteLine(name);
    }
}
