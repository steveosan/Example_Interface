using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_Interface
{
    public class Hammer : Tool 
    {
        public Hammer()
        {
            toolName = "Hammer";
            cost = 14;
        }

        public new void toolDecription()
        {
            System.Console.WriteLine($"Tool:{toolName}\n\tCost:${cost}");
            System.Console.WriteLine("* Walnut handel, steele");
        }

    }
}