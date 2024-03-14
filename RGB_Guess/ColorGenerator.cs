using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Guess
{
    class ColorGenerator
    {
        public ColorGenerator()
        {
        }

        public static Color GenerateColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
