namespace polymorphism
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.EatFood();
            // dog.Wang();   can't use derived method
            // just like this
            Dog realDog = (Dog) dog;
            realDog.Wang();
            // use base method
            realDog.EatFood();
            
            Cat cat = new Cat();
            cat.Miao();
            cat.EatFood();
        }
    }
}