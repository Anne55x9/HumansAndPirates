using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Captain : StandardHuman
    {
        public override void SayHello()
        {
            Console.WriteLine("Arrrr, you scurvy dog!");
        }
    }
}
