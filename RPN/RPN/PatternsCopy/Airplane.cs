using System;

namespace RPN.PatternsCopy
{
    public class Airplane
    {
        public int Velocity => State.Velocity;
        public int Gas => State.Gas;
        public bool OutOfGas(int? spent = null) => spent != null ? Gas - spent < 0 : Gas < 0;
        public bool TooFast(int? increase = null) => increase != null ? Velocity + increase > AirplaneState.MaxVelocity : Velocity > AirplaneState.MaxVelocity;

        public void IncreaseThrottle(int input)
        {
            State.IncreaseThrottle(input);
        }

        public void DecreaseThrottle(int input)
        {
            State.DecreaseThrottle(input);
        }

        public AirplaneState State { get; private set; }

        public Airplane()
        {
            State = new Grounded(this);
        }

        public void TransitionTo(AirplaneState state) {
            Console.WriteLine($"Context: Transition to {nameof(state)}.");
            State = state;
        }
    }
}
