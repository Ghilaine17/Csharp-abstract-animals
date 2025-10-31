using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Dog dog = new();
            Cat cat = new();
            Bird bird = new();
            Fish fish = new();

            List<Animal> animals = new() { dog, cat, bird, fish };

            foreach(var animal in animals)
            {
                Console.WriteLine($"Ecco il verso di {animal.GetType().Name}: '{animal.MakeSound()}' ed ecco cosa mangia: {animal.Eat()}");
                if(animal is IFly flyable)
                {
                    flyable.Fly();
                }
                if(animal is ISwim swimmable)
                {
                    swimmable.Swim();
                }
                Console.WriteLine();
            }

        }
    }
}
