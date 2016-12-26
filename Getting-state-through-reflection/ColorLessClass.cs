using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_state_through_reflection
{
    class ColorLessClass
    {
        [PropertyColor(ConsoleColor.DarkBlue)]
        private int DarkBlueProp { get; set; }

        [PropertyColor(ConsoleColor.DarkCyan)]
        private int DarkCyanProp { get; set; }

        [PropertyColor(ConsoleColor.DarkGray)]
        private int DarkGrayProp { get; set; }

        [PropertyColor(ConsoleColor.DarkYellow)]
        private int DarkYellowProp { get; set; }

        public ColorLessClass()
        { }

        public ColorLessClass(int blue, int cyan, int gray, int yellow)
        {
            DarkBlueProp = blue;
            DarkCyanProp = cyan;
            DarkGrayProp = gray;
            DarkYellowProp = yellow;
        }
    }
}
