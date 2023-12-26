namespace EventAndDelegates
{
    public class V_E_argus : EventArgs
    {
        //public Video? video { get; set; }
        public Video Video { get; internal set; }
    }
    internal class VideoEncoder
    {

        //1 Define a Delegate
        //2 Define an Event based on that delegate
        //3 Raise the event when particular action is been called 

        public delegate void videoEncoderEventHandler(Object o, V_E_argus e); //EventArgs e);

        public event videoEncoderEventHandler? V_Encoded; 
        public void Encode(Video video)
        {
            Console.WriteLine("Encoder VIdeo...");
            Thread.Sleep(2000); // Delay applicatiobn
            OnV_Encoded(video);
        
        }

        protected virtual void OnV_Encoded(Video v) 
        {
          /*  if (V_Encoded != null)
            {
                V_Encoded(this,new V_E_argus() { Video = v });//EventArgs.Empty);
            }*/
          V_Encoded?.Invoke(this,new V_E_argus() { Video = v });

        }
    }
}