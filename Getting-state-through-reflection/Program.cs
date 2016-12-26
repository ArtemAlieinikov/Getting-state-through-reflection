using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_state_through_reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorFullClass test = new ColorFullClass(100, "Hi", "How are you?", true, 18.5, new object(), 'X');
            ColorLessClass test1 = new ColorLessClass(50, 1, 0, 80);
            ClassProperties.PropertyValueColorPrint(test);
            ClassProperties.PropertyValueColorPrint(test1);
            //ClassProperties.PropertyInfoColorPrint(test);
        }
    }
}
