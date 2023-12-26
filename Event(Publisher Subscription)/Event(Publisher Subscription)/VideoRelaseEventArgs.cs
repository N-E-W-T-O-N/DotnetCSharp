namespace S
{
    public class VideoRelaseEventArgs : EventArgs
    {
        public string Title { get; }
        public VideoRelaseEventArgs(string t)
        {
            this.Title = t;
        }
    }
    public class PublisherEventArgs : EventArgs
    {
        public string Title{get ; }
        public PublisherEventArgs(string t)
        {
            this.Title = t; 
        }
    }
}
