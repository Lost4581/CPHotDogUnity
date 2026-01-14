using UnityEngine;

class OnionHotDog : HotdogDecorator
{
    public OnionHotDog(Hotdog h) : base(h.Name + ", с сладким луком", h.Cost + 30, h)
    { }
}