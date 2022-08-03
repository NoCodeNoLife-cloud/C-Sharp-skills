using System;

namespace Generic_type_constraints
{
    public class SuperCow : Cow
    {
        public SuperCow(string newName) : base(newName)
        {
        }

        public void Fly()
        {
            Console.Out.WriteLine("flying!");
        }

        public override void MakeANoise()
        {
            Console.Out.WriteLine("here I come to save the day!");
        }
    }
}