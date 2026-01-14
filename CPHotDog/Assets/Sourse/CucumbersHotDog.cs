using UnityEngine;

class CucumbersHotDog : HotdogDecorator
{
    public CucumbersHotDog(Hotdog h) : base(h.Name + ", с маринованными огурцами", h.Cost + 50, h)
    { }
}
