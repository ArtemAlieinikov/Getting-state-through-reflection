using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_state_through_reflection
{
    class ColorFullClass
    {
        [PropertyColor(ConsoleColor.Green)]
        private int GreenProperty { get; set; }

        protected static string SimpeProperty { get; set; }

        [PropertyColor(ConsoleColor.Red)]
        protected string RedProperty { get; set; }

        [PropertyColor(ConsoleColor.Yellow)]
        internal bool YellowProperty { get; set; }

        [PropertyColor(ConsoleColor.Cyan)]
        protected internal double CyanProperty { get; set; }

        [PropertyColor(ConsoleColor.Magenta)]
        public virtual object MagentaProperty { get; set; }

        [PropertyColor(ConsoleColor.Blue)]
        public object BlueProperty { get; set; }

        public ColorFullClass()
        { }

        public ColorFullClass(int green, string simple, string red, bool yellow, double cyan, object magenta, object blue)
        {
            GreenProperty = green;
            SimpeProperty = simple;
            RedProperty = red;
            YellowProperty = yellow;
            CyanProperty = cyan;
            MagentaProperty = magenta;
            BlueProperty = blue;
        }
    }
}
