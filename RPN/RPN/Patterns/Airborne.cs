using System;
using System.Collections.Generic;
using System.Text;

namespace RPN.Patterns
{
    public class Airborne : AirplaneState
    {
        public override void Move()
        {
            Console.WriteLine("Flying through the air.");
        }
    }
}