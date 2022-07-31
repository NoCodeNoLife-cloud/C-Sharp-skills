using System;
using System.Collections;

namespace CollectionBase_Inherit
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animals animalsCollection = new Animals();
            animalsCollection.Add(new Cow("Donna"));
            animalsCollection.Add(new Chicken("Kevin"));
            foreach (Animal item in animalsCollection)
            {
                item.Food();
            }
        }

        public class Animals : CollectionBase
        {
            public void Add(Animal newAnimals)
            {
                List.Add(newAnimals);
            }

            public void Remove(Animal newAnimals)
            {
                List.Remove(newAnimals);
            }

            public Animal this[int animalIndex]
            {
                get { return (Animal) List[animalIndex]; }
                set { List[animalIndex] = value; }
            }
        }

        public abstract class Animal
        {
            protected string name;

            abstract public void Food();
        }

        public class Cow : Animal
        {
            public Cow(string name)
            {
                this.name = name;
            }

            public override void Food()
            {
                Console.Out.WriteLine("Food Cow");
            }
        }

        public class Chicken : Animal
        {
            public Chicken(string name)
            {
                this.name = name;
            }

            public override void Food()
            {
                Console.Out.WriteLine("Food Chicken");
            }
        }
    }
}