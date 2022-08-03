using System.Collections;
using System.Collections.Generic;

namespace Generic_type_constraints
{
    public class Farm<T> : IEnumerable<T> where T:Animal
    {
        private List<T> animals = new List<T>();

        public List<T> Animals
        {
            get => animals;
        }

        public IEnumerator<T> GetEnumerator() => animals.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => animals.GetEnumerator();

        public void MakeNoises()
        {
            foreach (T animal in animals)
            {
                animal.MakeANoise();
            }
        }

        public Farm<Cow> GetCows()
        {
            Farm<Cow> cowFarm = new Farm<Cow>();
            foreach (T animal in animals)
            {
                if (animal is Cow)
                {
                    cowFarm.Animals.Add(animal as Cow);
                }
            }

            return cowFarm;
        }
    }
}