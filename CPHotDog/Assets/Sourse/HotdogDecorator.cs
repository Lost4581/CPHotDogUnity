using UnityEngine;

abstract class HotdogDecorator : Hotdog
{
    protected Hotdog hotdog;

    protected HotdogDecorator(string n, int c, Hotdog hotdog) : base(n, c)
    {
        this.hotdog = hotdog;
    }
}
