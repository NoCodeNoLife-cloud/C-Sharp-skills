using System;
using System.Collections;

namespace IDictionary_inherit
{    internal class Program
     {
         public static void Main(string[] args)
         {
             Animals animalsCollection = new Animals();
             animalsCollection.Add("Donna", new Cow("Donna"));
             animalsCollection.Add("Kevin", new Chicken("Kevin"));
             foreach (DictionaryEntry item in animalsCollection)
             {
                 ((Animal) item.Value).Food();
             }
         }
 
         public class Animals : DictionaryBase
         {
             public void Add(string newID, Animal newAnimal)
             {
                 Dictionary.Add(newID, newAnimal);
             }
 
             public void Remove(string animalID)
             {
                 Dictionary.Remove(animalID);
             }
 
             public Animal this[string animalID]
             {
                 get { return (Animal) Dictionary[animalID]; }
                 set { Dictionary[animalID] = value; }
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