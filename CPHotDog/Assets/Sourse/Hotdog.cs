using UnityEngine;

abstract class Hotdog
{
    public string Name { get; protected set; }
    public int Cost { get; protected set; }

    public Hotdog(string n, int c)
    {
        Name = n;
        Cost = c;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetCost()
    {
        return Cost;
    }
}
