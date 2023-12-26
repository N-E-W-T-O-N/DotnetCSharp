namespace DelegatE
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Pp = new PhotoProcessor();

            var filt = new PhotoFilters();
            //PhotoProcessor.PhotoFilterHandler filt_hand = filt.ApplyBrightness;
            Action<Photo> filt_hand = filt.ApplyBrightness;  // .NET delegate 
            filt_hand += filt.ApplyContrast;
            filt_hand += RemoveRedEyeFilter;
            filt_hand += ReverseImage;
            Pp.Process("Hello.jpg" , filt_hand);
        }

        static void RemoveRedEyeFilter(Photo p)
        {
            Console.WriteLine("RedEye Abnormality is been removed");
        }

        static void ReverseImage(Photo p)
        {
            Console.WriteLine("Reverse the image");
        }
    }
}