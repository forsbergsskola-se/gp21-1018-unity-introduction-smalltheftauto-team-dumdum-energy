using System;
using System.Collections.Generic;

namespace ZooOR
{
    class Zoo<TAnimal> where TAnimal : Animal, new() //Makes sure I can only add zoos with animals in them
    {
        List<TAnimal> animals = new List<TAnimal>(); 
        
        
        public void AddAnimal(TAnimal animal)
            {
                // Increases size of array that holds TAnimals by one, whenever we AddAnimal/no longer true, now it interacts with list instead
                this.animals.Add(animal);
                //Here we put it into new space created by array/ used to, replaced by list above
                //Since we start at 0, we need to subtract 1, this means the animal added is "put at the end"/sorted at the end.
                //animals[^1] = animal; - can be used if using array
            }

        public bool HasAnimal<TSpecies>() where TSpecies : Animal
        {
            for (int i = 0; i < animals.Count; i++)
                {
                    if (animals[i] is TSpecies)
                    {
                        Console.WriteLine(animals[i]);
                        return true;
                    }
                    
                }
                return false;
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
    public class Donkeh : Mammal
    {
        
    }
    public class Simba : Mammal
    {
        
    }
    public class Fishy : Animal
    {
        
        
    }
    public class Salmon : Fishy
    {
        
    }
    public class Nemo : Fishy
    {
        
        
    }

    public class Student
    {
        
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Zoo<Fishy> fishyZoo = new Zoo<Fishy>();
            fishyZoo.AddAnimal(new Fishy()); // Adds new Fish
            fishyZoo.AddAnimal(new Nemo()); // Adds new clownfish
            //Zoo<Student> studenTAnimal = new Zoo<Student>(); -> Can't add student Zoo(sadly)
            Zoo<Simba> simbaZoo = new Zoo<Simba>();
            simbaZoo.AddAnimal(new Simba());
            simbaZoo.AddAnimal(new Simba());
            Zoo<Mammal> mammalZoo = new Zoo<Mammal>();
            mammalZoo.AddAnimal((new Donkeh()));

            Zoo<Salmon> salmonZoo = new Zoo<Salmon>();
            salmonZoo.HasAnimal<Salmon>(); //Making use of hasanimal public method. See method in Zoo class for more
            Console.WriteLine("This Zoo has: Nemos? "+fishyZoo.HasAnimal<Nemo>());
            Console.WriteLine("This Zoo has lions in the fishy zoo? "+fishyZoo.HasAnimal<Simba>());


        }
    }
}
