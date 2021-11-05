using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_Interface
{
    public class Tool : IToolBox
    {
        public string toolName {get; set;}
        public int cost {get; set;}

        public void toolDecription()
        {

        }
    }
}