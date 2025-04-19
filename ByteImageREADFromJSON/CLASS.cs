public class ThumbNailPhoto
{
        public string type { get; set; }
        public Byte[] data { get; set; }
}

public class X
{
        public ThumbNailPhoto ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
}

public class Root
{
        public list<X> x { get; set; }
}