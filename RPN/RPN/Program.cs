using System;
using RPN.Patterns;

namespace RPN
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Airplane();
            p.State.Move();
            p.TransitionTo(new TakingOff());
            p.State.Move();
            p.TransitionTo(new Airborne());
            p.State.Move();
            Console.WriteLine("Hello World!");
        }
    }
}
