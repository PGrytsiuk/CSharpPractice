using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class ImageValidator
    {
        public static void ImageValidatorMethod(int width, int height)
        {
            if (width == 0 || width <= 0)
            {
                Console.WriteLine("Invalid width");

            }

            if (height == 0 || height <= 0)
            {
                Console.WriteLine("Invalid height");
            }

            var orientation = width > height ? ImageOrientation.Landscape :
                     width < height ? ImageOrientation.Portrait :
                     ImageOrientation.Square;
            Console.WriteLine("Image orientation is " + orientation);
        }
    }
}
