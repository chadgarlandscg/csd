using System;
using System.Collections.Generic;
using System.Text;

namespace RPN.Patterns
{
    class Airplane
    {
        public AirplaneState State { get; private set; } = new Grounded();

        public void TransitionTo(AirplaneState state) {
            Console.WriteLine($"Context: Transition to {nameof(state)}.");
            State = state;
        }
}
}
