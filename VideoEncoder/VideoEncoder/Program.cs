namespace EventAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var video = new Video() { Title = "Hello_KILL_Bill" };
            var videoEncoder = new VideoEncoder(); //Publisher

            var mail = new MailService(); //sUBSCRIBER
            var mess = new MessageService(); //Mess subscriber

              
            videoEncoder.V_Encoded += mail.OnV_Encoded;// new Mail
            videoEncoder.V_Encoded += mess.OnV_Encoded;
            videoEncoder.Encode(video);//(new Video("Hello_Kill_Bill"))
        }
    }

 }