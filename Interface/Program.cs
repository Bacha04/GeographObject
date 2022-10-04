interface IGeographicalObject
{
    decimal x { get; }
    decimal y { get; }
    string name { get; }
    string description { get; }
    virtual void GetInfo()
    {
    }
}

class River : IGeographicalObject
{
    public decimal x { get;}
    public decimal y { get;}
    public string name { get;}
    public string description { get;}
    public double speed { get; }
    public double length { get; }
}

class Mountain : IGeographicalObject
{
    public decimal x { get; }
    public decimal y { get; }
    public string name { get; }
    public string description { get; }
    public double peak { get; }
}