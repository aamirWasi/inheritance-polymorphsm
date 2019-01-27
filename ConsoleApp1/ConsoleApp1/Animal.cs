using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        private string name;
        protected string sound;

        protected AnimalIDInfo animalInfo = new AnimalIDInfo();
        public void SetAnimalIDInfo(int idNum,string owner)
        {
            animalInfo.IdNum = idNum;
            animalInfo.Owner = owner;
        }
        public void GetAnimalInfo()
        {
            Console.WriteLine($"{Name} had the Id of {animalInfo.IdNum} & is owned by {animalInfo.Owner}");
        }


        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal()
            :this("No Name","No Sound") { }
        public Animal(string name)
            :this(name,"No Sound") { }

        public Animal(string name,string sound)
        {
            Name = name;
            Sound = sound;
        }

        
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = value;
                }
                else
                {
                    name = "No Name";
                }
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length >10)
                {
                    sound = "No Sound";
                }
                else
                {
                    sound = value;
                }
            }
        }
        //inner class
        public class AnimalHealth
        {
            public bool HealthyWeight(double height,double weight)
            {
                double calc = height / weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                return false;
            }
        }

    }
}
