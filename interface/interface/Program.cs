namespace interface_demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.EatFood();
            Cat cat = new Cat();
            cat.EatFood();
        }
    }
}