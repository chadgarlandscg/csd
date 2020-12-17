namespace RPN.PatternsCopy
{
    public abstract class AirplaneState
    {
        public static int MaxVelocity = 100;
        public static int MinVelocity = 0;
        public int Velocity { get; protected set; } = MinVelocity;
        public int Gas { get; protected set; } = 100;

        protected readonly Airplane Airplane;

        protected AirplaneState(Airplane airplane)
        {
            Airplane = airplane;
        }

        public void IncreaseThrottle(int input)
        {
            var gasSpent = (input + 1);
            if (Airplane.OutOfGas(gasSpent))
            {
                return;
            }

            if (Airplane.TooFast(input))
            {
                Velocity = MaxVelocity;
                return;
            }
            Gas -= gasSpent;
            Velocity += input;
        }

        public void DecreaseThrottle(int input)
        {
            if (Velocity - input < MinVelocity)
            {
                Velocity = MinVelocity;
                return;
            }
            Velocity -= input;
        }
    }
}
