namespace Generic_type_constraints
{
    public abstract class Animal
    {
        private string _name;

        public Animal(string name)
        {
            _name = name;
        }

        public abstract void MakeANoise();
    }
}