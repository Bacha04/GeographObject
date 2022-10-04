using System;

abstract class GeographicalObject 
{
    private decimal x;
    private decimal y;
    private string name;
    private string description;
    public virtual void GetInfo() 
    {
    }
}
class River : GeographicalObject 
{
    private double speed;
    private double length;
}

class Mountain : GeographicalObject 
{
    private double peak;
}