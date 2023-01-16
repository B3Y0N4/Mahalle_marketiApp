using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalle_marketi
{
    internal class IdGenerator
    {
        public static string NewId() => DateTime.Now.Ticks.ToString("x");

    }
}
