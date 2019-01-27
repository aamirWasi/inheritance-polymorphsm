using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Greee"
            };
            whiskers.MakeSound();
            grover.MakeSound();
            whiskers.Sound = "Meoooow";
            grover.Sound = "Grrreeee";
            grover.Name = "gronver";
            grover.MakeSound();
            whiskers.MakeSound();


            whiskers.SetAnimalIDInfo(123456, "Sally Smith");
            grover.SetAnimalIDInfo(156, "Paul Brown");


            whiskers.GetAnimalInfo();
            grover.GetAnimalInfo();


            //innerClass
            Animal.AnimalHealth GetHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my Animal is healthy : {0}",GetHealth.HealthyWeight(11,46));


            //polymorphsm

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeee"
            };
            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Gooooowww",
                Sound2 = "Woooof"
            };
            monkey.MakeSound();
            spot.MakeSound();
        }
    }
}
