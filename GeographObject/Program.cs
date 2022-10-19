using System;
using System.Runtime.CompilerServices;

Mountain mountain = new Mountain();
mountain.description = "The highest mountain in the world ";
mountain.peak = 2003;
mountain.GetInfo();
abstract class GeographicalObject 
{
    public decimal x;
    public decimal y;
    public string name;
    public string description;
    public virtual void GetInfo() 
    {
        Console.WriteLine(description); 
    }
}
class River : GeographicalObject
{
    private double speed;
    private double length;
    public override void GetInfo()
        {
        base.GetInfo();
        Console.WriteLine(length);    
        }
}

class Mountain : GeographicalObject 
{
    public double peak;
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine(peak);
    }
}
