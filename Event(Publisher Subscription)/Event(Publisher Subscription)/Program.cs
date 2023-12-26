using System;

namespace S
{
     // public void HandleNewVideoReleas
    class HelloWorld
    {

        static void Main()
        {

            var p = new publisher("KING");

            var s1 = new subscriber("S1");
            var s2 = new subscriber("S2");

            s1.Subscribe(p);
            s2.Subscribe(p);
            //In the above code p is transfer as a input which we dont 
            // The implement should be like this
            // p.Onsubscribe += s1.HandlerOnSubscriber
            // also instead of passing publisher instance pass its p handlers 
            //Just send Its only new
            p.OnVideoRelease("I AM THE ONE!!!!");

            s2.UnSubscribe(p);
            //p.UnSubscribe(s2);
        }
    }
}
