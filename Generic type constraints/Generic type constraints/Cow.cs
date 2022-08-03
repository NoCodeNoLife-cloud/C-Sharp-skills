using System;

namespace Generic_type_constraints
{
    public class Cow : Animal
    {
        public Cow(string name) : base(name)
        {
        }

        public override void MakeANoise()
        {
            Console.Out.WriteLine("moo!");
        }
    }
}