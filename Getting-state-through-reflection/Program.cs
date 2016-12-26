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
            ClassProperties.PropertyValueColorPrint(test);
            //ClassProperties.PropertyInfoColorPrint(test);
        }
    }
}
