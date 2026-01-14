using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private void Awake()
    {
        Hotdog classicHotDog = new ClassicHotDog();
        Hotdog cucumbersHotDog1 = new CucumbersHotDog(classicHotDog);
        Hotdog onionHotDog1 = new OnionHotDog(classicHotDog);

        Hotdog caesarHotDog = new CaesarHotDog();
        Hotdog cucumbersHotDog2 = new CucumbersHotDog(caesarHotDog);
        Hotdog onionHotDog2 = new OnionHotDog(caesarHotDog);

        Hotdog meetHotDog = new MeetHotDog();
        Hotdog cucumbersHotDog3 = new CucumbersHotDog(meetHotDog);
        Hotdog onionHotDog3 = new OnionHotDog(meetHotDog);

        string message1 = $"{classicHotDog.Name} Ч {classicHotDog.Cost}р.\n" +
                         $"ƒополнительна€ информаци€:\n" +
                         $"{cucumbersHotDog1.Name} Ч {cucumbersHotDog1.Cost}р.\n" +
                         $"{onionHotDog1.Name} Ч {onionHotDog1.Cost}р.";

        string message2 = $"{caesarHotDog.Name} Ч {caesarHotDog.Cost}р.\n" +
                         $"ƒополнительна€ информаци€:\n" +
                         $"{cucumbersHotDog2.Name} Ч {cucumbersHotDog2.Cost}р.\n" +
                         $"{onionHotDog2.Name} Ч {onionHotDog2.Cost}р.";

        string message3 = $"{meetHotDog.Name} Ч {meetHotDog.Cost}р.\n" +
                         $"ƒополнительна€ информаци:\n" +
                         $"{cucumbersHotDog3.Name} Ч {cucumbersHotDog3.Cost}р.\n" +
                         $"{onionHotDog3.Name} Ч {onionHotDog3.Cost}р.";

        Debug.Log(message1);
        Debug.Log(message2);
        Debug.Log(message3);
    }
}
