using System;

namespace RPN.PatternsCopy
{
    public class Grounded : AirplaneState
    {
        public new void IncreaseThrottle(int input)
        {
            base.IncreaseThrottle(input);
            Console.WriteLine("Rolling forward on the ground.");
            if (Velocity > 0)
            {
                Airplane.TransitionTo(new TakingOff(Airplane));
            }
        }

        public new void DecreaseThrottle(int input)
        {
            base.DecreaseThrottle(input);
            Console.WriteLine("Slowing down on the ground.");
        }

        public Grounded(Airplane airplane) : base(airplane)
        {
        }
    }
}
