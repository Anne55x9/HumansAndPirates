using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class HumanFactory
    {
        public IHuman CreateHuman(String choice)
        {
            if (choice == "P")
            {
                return (new Pirate());
            }
            if (choice == "H")
            {
                return (new StandardHuman());
            }

            return null;
        }
    }
}
