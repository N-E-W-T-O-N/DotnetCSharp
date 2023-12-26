namespace S
{
    class publisher
    {
        private string _name;
        
        public event EventHandler<VideoRelaseEventArgs> OnNewVideoRelease;
        

        public publisher(string s)
        {
            this._name = s;
            //Console.WriteLine($"Publisher {_name} is been created")
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void OnVideoRelease(string s)
        {
            Console.WriteLine($"A new video is release : {s}");
            OnNewVideoRelease?.Invoke(this, new VideoRelaseEventArgs(s));//publisher will be send as sender 
        }


    }
}
