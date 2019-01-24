using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Flash : Storage
    {
        public Flash(int memory, int speed)
        {
            Memory = memory;
            Speed = speed;
        }
    }
}
