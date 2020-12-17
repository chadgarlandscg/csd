using System;
using System.Collections.Generic;
using System.Text;

namespace RPN.Patterns
{
    public class Grounded : AirplaneState
    {
        public override void Move()
        {
            Console.WriteLine("Rolling forward on the ground.");
        }
    }
}
