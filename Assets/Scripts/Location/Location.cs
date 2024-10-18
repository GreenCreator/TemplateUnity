using System;

public class Location : GameEntity<LocationData>
{
    public Location(Func<LocationData> dataLoader) : base(dataLoader)
    {
    }
}