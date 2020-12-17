using System;

namespace RPN.PatternsCopy
{
    public class Airborne : AirplaneState
    {
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

        public Airborne(Airplane airplane) : base(airplane)
        {
        }
    }
}