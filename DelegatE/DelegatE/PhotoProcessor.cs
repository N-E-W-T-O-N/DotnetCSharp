namespace DelegatE
{
    public class PhotoProcessor
    {
        /*        Without Delegate
                 public void Process(string path) 
                {
                    var photo  = Photo.Load(path);

                    var filters = new PhotoFilters();

                    filters.ApplyBrightness(photo);
                    filters.ApplyContrast(photo);
                    filters.ApplyResize(photo);

                    photo.Save();
        }*/
/*
        custom Delegate
        public delegate void PhotoFilterHandler(Photo p);
        //Delegate
        public void Process(string path, PhotoFilterHandler filt_hand)
*/
        public void Process(String path , Action<Photo> filt_hand)
        {

            var photo  =Photo.Load(path);

            filt_hand(photo);

            photo.Save();
        }



}
}