using System;
using System.Xml.Linq;

namespace S
{
    class subscriber
    {
        public event EventHandler<PublisherEventArgs> OnSubcription;    //(object o, Event e);
        public event EventHandler<PublisherEventArgs> OnUnSubcription;
        public string s_name { get; set; }

        public subscriber(string S)
        {
            this.s_name = S;
            //Console.WriteLine($"Subscriber {s_name} is been created");
        }
        public void Subscribe(publisher p)
        {
            OnSubcription += message.HandleSubscription;//Since subscriber is
            OnSubcription.Invoke(this, new PublisherEventArgs(p.Name));
            //p.OnSubcription.Invoke()
            p.OnNewVideoRelease += message.HandleNewVideoReleas;
            //p.OnUnSubcription += (sender, e) => Console.WriteLine($"You have UnSubscribe {((publisher)sender).Name}");//HandleUnScription ; // ;
        }

        public void UnSubscribe(publisher p)
        {
            //p.OnSubcription?.Invoke(this)
            OnSubcription -= message.HandleSubscription;//
            p.OnNewVideoRelease -= message.HandleNewVideoReleas; //
            OnUnSubcription = message.HandleOnSubscription;
            OnUnSubcription.Invoke(this, new PublisherEventArgs(p.Name));
            //(sender, e) => Console.WriteLine($"{s_name} have Unsubscribed to {e.Title}");

            //p.OnUnSubcription.Invoke(this, new PublisherEventArgs(p.Name));
            //p.OnUnSubcription -= (sender, e) => Console.WriteLine($"You have UnSubscribe {((publisher)sender).Name}");
            //=HandleUnScription //recale onlyonce

        }
    }
}
