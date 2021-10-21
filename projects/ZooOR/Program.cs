using System;
using System.Collections.Generic;

namespace ZooOR
{
    class Zoo<TAnimal> where TAnimal : Animal, new() //Makes sure I can only add zoos with animals in them
    {
        List<TAnimal> animals = new List<TAnimal>(); // This is array, How do me use diz?
        
        
        public void AddAnimal(TAnimal animal)
            {
                // Increases size of array that holds TAnimals by one, whenever we AddAnimal
                this.animals.Add(animal);
                //Here we put it into new space created by array
                //Since we start at 0, we need to subtract 1, this means the animal added is "put at the end"/sorted at the end.
                //animals[^1] = animal;
            }

        public bool HasAnimal<TSpecies>() where TSpecies : Animal
        {
            
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
        Nemo nemo = new Nemo();
        
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
            
            Zoo<Salmon> salmonZoo = new Zoo<Salmon>();
            salmonZoo.HasAnimal<Salmon>(); //Here we make use of hasanimal public method. See method in Zoo class for more
           // Console.WriteLine("This is a lie: "+fishyZoo.HasAnimal<Nemo>()); //Doesn't work for some reason


        }
    }
}
