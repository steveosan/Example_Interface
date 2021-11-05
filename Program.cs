using System;

namespace Example_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::ToolBox Interface:::\n");

             Hammer myHammer = new Hammer();
             myHammer.toolDecription();

                System.Console.WriteLine("");

             Level myLevel = new Level();
             myLevel.toolDecription();
             
            System.Console.WriteLine("\n:::End of interface:::\n\n");


            //Thank you for helping and being patient Mark; Taking the time to understand this with us all is really appreciated!

        }
    }
}
