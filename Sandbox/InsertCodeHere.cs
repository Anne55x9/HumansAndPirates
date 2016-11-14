using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            // A List that can hold objects which implement the 
            // IHuman interface
            List<IHuman> everybody = new List<IHuman>();


            // PART 1 - Start
            everybody.Add(new StandardHuman());
            everybody.Add(new Pirate());
            everybody.Add(new Pirate());
            everybody.Add(new StandardHuman());

            foreach (IHuman h in everybody)
            {
                h.SayHello();
            }
            Console.WriteLine("List printed at the end of Part 1 ");

            return; // REMOVE THIS LINE WHEN YOU ARE DONE WITH PART 1
            // PART 1 - End


            // PART 2
            everybody.Clear();
            HumanFactory hFac = new HumanFactory();
            everybody.Add(hFac.CreateHuman("P"));
            everybody.Add(hFac.CreateHuman("H"));
            everybody.Add(hFac.CreateHuman("H"));
            everybody.Add(hFac.CreateHuman("P"));
            everybody.Add(hFac.CreateHuman("P"));

            foreach (IHuman h in everybody)
            {
                h.SayHello();
            }
            Console.WriteLine("List printed at the end of Part 2 ");

            return; // REMOVE THIS LINE WHEN YOU ARE DONE WITH PART 2
            // PART 2 - End


            // PART 3
            everybody.Clear();
            Console.Write("Input P for Pirate, H for Human, Q for Quit : ");
            String input = "";
            while (input != "Q")
            {
                input = Console.ReadLine();
                if (input != "Q")
                {
                    IHuman h = hFac.CreateHuman(input);
                    if (h != null)
                    {
                        everybody.Add(h);
                    }

                    Console.Write("Input P for Pirate, H for Human, Q for Quit : ");
                }
            }

            foreach (IHuman h in everybody)
            {
                h.SayHello();
            }
            Console.WriteLine("List printed at the end of Part 3 ");
            // PART 3 - End

            // The LAST line of code should be ABOVE this line
        }
    }
}
