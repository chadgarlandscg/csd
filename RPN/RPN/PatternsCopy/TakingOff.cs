using System;

namespace RPN.PatternsCopy
{
    public class TakingOff : AirplaneState
    {
        public new void IncreaseThrottle(int input)
        {
            base.IncreaseThrottle(input);
            if (Velocity == MaxVelocity)
            {
                Airplane.TransitionTo(new Airborne(Airplane));
                return;
            }
            Console.WriteLine("ALMOST THERE!");
        }

        public new void DecreaseThrottle(int input)
        {
            base.DecreaseThrottle(input);
            if (Velocity == MinVelocity)
            {
                Airplane.TransitionTo(new Grounded(Airplane));
                return;
            }
            Console.WriteLine("Aborting takeoff?");
        }

        public TakingOff(Airplane airplane) : base(airplane)
        {
            Velocity = airplane.Velocity;
            Gas = airplane.Gas;
        }
    }
}
