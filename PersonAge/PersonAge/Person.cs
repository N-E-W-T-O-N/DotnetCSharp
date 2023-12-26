using System;

namespace PersonAge
{
    public class Person
    {
        // public int MyProperty { get; set; }
        
        public DateTime BirthDay { get ; set; }

        public int age
        {
            get
            {
                var t_span = DateTime.Today - BirthDay;

                return t_span.Days / 365;
            }

        }

    }
}
