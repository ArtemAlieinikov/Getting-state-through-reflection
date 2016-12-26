using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_state_through_reflection
{
    [AttributeUsage(AttributeTargets.Property)]
    class PropertyColorAttribute : Attribute
    {
        private ConsoleColor propColor;

        public ConsoleColor PropColor
        {
            get
            {
                return propColor;
            }
            private set
            {
                propColor = value;
            }
        }

        public PropertyColorAttribute(ConsoleColor color)
        {
            propColor = color;
        }
    }
}
