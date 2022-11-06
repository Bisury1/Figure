using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public static class Swapper
    {
        public static void Swap(ref double a, ref double b) => (a, b) = (b, a);
    }
}
