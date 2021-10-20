using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

namespace ZooJD
{
    class Program
    {
        static void Main()
        {
            Test();
        }
    }

    class Animal
    {
        
    }

    class Mammal : Animal
    {
        
    }

    class Bear : Mammal
    {
        
    }

    class Donkey : Mammal
    {
        
    }

    class Lion : Mammal
    {
        
    }

    class Fish : Animal
    {
        
    }

    class Salmon : Fish
    {
        
    }

    class Clownfish : Fish
    {
        
    }

    class Student
    {
        
    }

    class Zoo<TAnimal> where TAnimal : Animal, new()
    {
        private TAnimal[] _animals;

        public void BigArray()
        {
            Array.Resize(ref _animals,_animals.Length + 1);
        }
        public TAnimal AddAnimal<TAnimal>(TAnimal animal) where TAnimal : Animal,new()
        {
            animal = new TAnimal();
            return animal;
        }

        public bool HasAnimal<TAnimal>()
        {
            return false;
        }

        public void Test()
        {
            Zoo<Animal> animalZoo2 = new Zoo<Animal>();
            animalZoo2.AddAnimal(new Fish()); // OKAY
            animalZoo2.AddAnimal(new Clownfish()); // OKAY
            animalZoo2.AddAnimal(new Lion()); // OKAY
            animalZoo2.AddAnimal(new Donkey()); // OKAY 
            
                Zoo<Fish> fishZoo = new Zoo<Fish>();
                fishZoo.AddAnimal<Salmon>();
                fishZoo.AddAnimal<Salmon>();
                Console.WriteLine("This should be False: "+fishZoo.HasAnimal<Clownfish>());
                
                Zoo<Fish> fishZoo2 = new Zoo<Fish>();
                fishZoo.AddAnimal<Salmon>();
                fishZoo.AddAnimal<Clownfish>();
                fishZoo.AddAnimal<Salmon>();
                Console.WriteLine("This should be True: "+fishZoo2.HasAnimal<Clownfish>());
                
                Zoo<Animal> animalZoo = new Zoo<Fish>();
                animalZoo.AddAnimal<Salmon>();
                animalZoo.AddAnimal<Lion>();
                animalZoo.AddAnimal<Donkey>();
                Console.WriteLine("This should be True: "+fishZoo.HasAnimal<Fish>());
            
        }

    }
}