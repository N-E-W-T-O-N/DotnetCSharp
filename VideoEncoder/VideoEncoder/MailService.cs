namespace EventAndDelegates
{
    public class MailService 
    {
        public void OnV_Encoded(Object o, V_E_argus e)
        {
            Console.WriteLine($"MailService: Sending an email Event for video Encoded  {e.Video.Title}");
        }
    }
}
 