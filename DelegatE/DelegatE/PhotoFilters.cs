using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatE
{
    public  class PhotoFilters
    {
        

        public void ApplyBrightness(Photo p)
        {
            Console.WriteLine("Brightness is applied to the Photo");

        }

        public void ApplyContrast(Photo p)
        {
            Console.WriteLine("Contrast is applied");
        }

        public void ApplyResize(Photo p)
        {
            Console.WriteLine("Resize the image");
        }

        
    }
}
