using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            
            Zoo<Animal> animalZoo = new Zoo<Animal>();
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
        List<TAnimal> _animals = new ();

        public void AddAnimal(TAnimal animal)
        {
               _animals.Add(animal);
        }

        public bool HasAnimal<TSpecies>() where TSpecies : TAnimal
        {
            for (int i = 0; i < _animals.Count; i++)
            {
                if (_animals[i] is TSpecies)
                {
                    return true;
                }
            }
            return false;
        }

    }
//foreach (var VARIABLE in _animals)
//{
//    if (Equals(VARIABLE, test))         //Needs to check both the class and parent-class type, how though?
//    {
//        return true;
//    }
//}
//return false;