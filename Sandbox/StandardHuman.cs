using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class StandardHuman : IHuman
    {
        public virtual void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
