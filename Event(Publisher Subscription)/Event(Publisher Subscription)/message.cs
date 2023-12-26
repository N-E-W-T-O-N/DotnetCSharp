namespace S
{
    public class message
    {
        public static void HandleSubscription(object sender, PublisherEventArgs e) 
            => Console.WriteLine($"{((subscriber)sender).s_name} has subscribe to {e.Title}");

        public static void HandleNewVideoReleas(object sender, VideoRelaseEventArgs e)
        {
            Console.WriteLine($"{((publisher)sender).Name} has been notified of a new video release: {e.Title}");
        }

        public static void HandleOnSubscription(object sender, PublisherEventArgs e)
            => Console.WriteLine($"Hey {((subscriber)sender).s_name} you have Unsubscriber the {e.Title}");
    }
}
