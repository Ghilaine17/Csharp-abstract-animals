using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        public abstract class Animal()
        {
            public abstract string Eat();
            public static void Sleep()
            {
                Console.WriteLine("Zzz...");
            }
            public abstract string MakeSound();
        }

        public class Dog : Animal
        {
         public override string Eat()
            {
            return "Mangio crocchette e cibo in scatola";
        }
            public override string MakeSound()
            { return "Bau Bau!";
        }
        }
        public class Cat : Animal
        {
            public override string Eat()
                { return "Mangio croccantini e lische di pesce";
        }
            public override string MakeSound()
            {
                return "Meow!";
            }
        }
        public class Bird : Animal, IFly
        {
            public override string Eat()
            {
                return "Mangio semi e piccoli insetti";
            }
            public override string MakeSound()
            {
                return "Cip, Cip!";
            }
            void IFly.Fly()
            {
                Console.WriteLine("So volare");
            }
        }
        public  class Fish : Animal, ISwim
        {
            public override string Eat()
            {
                return "Mangio gameretti e piccoli pesciolini";
            }
            public override string MakeSound()
            { return "Blub, Blub!";
        }
            void ISwim.Swim()
            {
                Console.WriteLine("So nuotare");
            }
        }
        public interface ISwim
        {
            public void Swim();
        }
        public interface IFly
        {
            public void Fly();
        }
    }
