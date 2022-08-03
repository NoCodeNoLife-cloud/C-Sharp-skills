using System;

namespace Generic_type_constraints
{
    public class Chicken : Animal
    {
        public Chicken(string name) : base(name)
        {
        }

        public override void MakeANoise()
        {
            Console.Out.WriteLine("cluck!");
        }
    }
}