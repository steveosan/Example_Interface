using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_Interface
{
    public class Level : Tool
    {
        public Level()
        {
            toolName = "Level";
            cost = 32;
        }

        public new void toolDecription()
        {
            System.Console.WriteLine($"Tool:{toolName}\n\tCost:${cost}");
            System.Console.WriteLine("* Aluminum & Provides accuracy within .0005”/in. in all working positions");
            System.Console.WriteLine("* Limited lifetime warranty on frame and vials");
        }      
    }
}