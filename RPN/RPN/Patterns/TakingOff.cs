using System;
using System.Collections.Generic;
using System.Text;

namespace RPN.Patterns
{
    public class TakingOff : AirplaneState
    {
        public override void Move()
        {
            Console.WriteLine("ALMOST THERE!");
        }
    }
}
