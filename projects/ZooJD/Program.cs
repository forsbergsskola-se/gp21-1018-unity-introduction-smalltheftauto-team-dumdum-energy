using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

namespace ZooJD
{
    public class Program
    {
        static void Main()
        {
            Zoo<Fish> fishZoo = new Zoo<Fish>();
            fishZoo.AddAnimal(new Salmon());
            fishZoo.AddAnimal(new Salmon());
            Console.WriteLine("This should be False: " + fishZoo.HasAnimal<Clownfish>());

            Zoo<Fish> fishZoo2 = new Zoo<Fish>();
            fishZoo2.AddAnimal(new Salmon());
            fishZoo2.AddAnimal(new Clownfish());
            fishZoo2.AddAnimal(new Salmon());
            Console.WriteLine("This should be True: " + fishZoo2.HasAnimal<Clownfish>());
            
            Zoo<Animal> animalZoo = new Zoo<Fish>();
            animalZoo.AddAnimal(new Salmon());
            animalZoo.AddAnimal(new Lion());
            animalZoo.AddAnimal(new Donkey());
            Console.WriteLine("This should be True: "+fishZoo.HasAnimal<Fish>());
        }
    }
}

public class Animal
    {
        
    }

    public class Mammal : Animal
    {
        
    }

    public class Bear : Mammal
    {
        
    }

    public class Donkey : Mammal
    {
        
    }

    public class Lion : Mammal
    {
        
    }

    public class Fish : Animal
    {
        
    }

    public class Salmon : Fish
    {
        
    }

    public class Clownfish : Fish
    {
        
    }

    public class Student
    {
        
    }

    public class Zoo<TAnimal> where TAnimal : Animal, new()
    {
        public TAnimal[] _animals = Array.Empty<TAnimal>();
        
        public void AddAnimal(TAnimal animal)
        {
                Array.Resize(ref _animals,_animals.Length+1);
                _animals[^1] = animal;

        }

        public bool HasAnimal<TAnimal>()
        {
            var test = typeof(TAnimal);
            foreach (var VARIABLE in _animals)
            {
                //var position = VARIABLE.ToString().IndexOf('.')+1;
                //var variable =VARIABLE.ToString().Substring(position);
                if (Equals(VARIABLE, test))         //Needs to check both the class and parent-class type, how though?
                {
                    return true;
                }
            }
            return false;
        }

    }
