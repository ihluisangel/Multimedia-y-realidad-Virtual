using System.Collections;
using System.Collections.Generic;

public class Clicker{
    public bool clicked()
    {
#if (UNITY_ANDROID || UNITY_IPHONE)
        return Cardboard.SDK.CardboardTriggered;
#else
        return Input.anyKeyDown;
#endif
    }   
}
