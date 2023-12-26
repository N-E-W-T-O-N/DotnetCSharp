
namespace EventAndDelegates
{
    public class MessageService
    {
        public void OnV_Encoded(Object o , V_E_argus args)
        {
            Console.WriteLine($"Message is been text for new {args.Video.Title} ");
        }
    }
}