using System;
using System.Collections.Generic;
using System.Linq;

namespace ZooEK
{
    class Program
    {
        
        static void Main(string[] args)
        {

           /* {
                Zoo<Fish> fishZoo = new Zoo<Fish>();
                fishZoo.AddAnimal(new Fish()); // OKAY
                fishZoo.AddAnimal(new Clownfish()); // OKAY
            }

            {
                Zoo<Animal> animalZoo = new Zoo<Animal>();
                animalZoo.AddAnimal(new Fish()); // OKAY
                animalZoo.AddAnimal(new Clownfish()); // OKAY
                animalZoo.AddAnimal(new Lion()); // OKAY
                animalZoo.AddAnimal(new Donkey()); // OKAY
            }

            {
                Zoo<Lion> lionZoo = new Zoo<Lion>();
                lionZoo.AddAnimal(new Lion()); // OKAY
                lionZoo.AddAnimal(new Lion()); // OKAY
                lionZoo.AddAnimal(new Lion()); // OKAY
            }*/

            /*{
                Zoo<Student> studentZoo = new StudentZoo(); // ERROR!
            }

            {
                Zoo<Fish> fishZoo = new Zoo<Fish>();
                fishZoo.AddAnimal(new Lion());
            }

            {
                Zoo<Student> studentZoo = new StudentZoo(); // ERROR!
            }

            {
                Zoo<Fish> fishZoo = new Zoo<Fish>();
                fishZoo.AddAnimal(new Lion()); // ERROR!
            }

            {
                Zoo<Animal> animalZoo = new Zoo<Animal>();
                animalZoo.AddAnimal(new Student()); // ERROR!
            }

            {
                Zoo<Salmon> salmonZoo = new Zoo<Salmon>();
                salmonZoo.AddAnimal(new Fish()); // ERROR!
            }

            {
                Zoo<Salmon> salmonZoo = new Zoo<Salmon>();
                salmonZoo.HasAnimal<Lion>(); // ERROR!
            }*/

            {
                Zoo<Fish> fishZoo = new Zoo<Fish>();
                fishZoo.AddAnimal(new Salmon());
                fishZoo.AddAnimal(new Salmon());
                Console.WriteLine("This should be False: " + fishZoo.HasAnimal<Clownfish>());
            }

            {
                Zoo<Fish> fishZoo = new Zoo<Fish>();
                fishZoo.AddAnimal(new Salmon());
                fishZoo.AddAnimal(new Clownfish());
                fishZoo.AddAnimal(new Salmon());
                Console.WriteLine("This should be True: " + fishZoo.HasAnimal<Clownfish>());
            }

            {
                Zoo<Animal> animalZoo = new Zoo<Animal>();
                animalZoo.AddAnimal(new Salmon());
                animalZoo.AddAnimal(new Lion());
                animalZoo.AddAnimal(new Donkey());
                Console.WriteLine("This should be True: " + animalZoo.HasAnimal<Fish>());
            }

        }
    }
}

class Zoo<TAnimal> where TAnimal : Animal, new()
{
    //TAnimal[] animals = Array.Empty<TAnimal>();
    List<TAnimal> animals = new List<TAnimal>();
    internal void AddAnimal(TAnimal animal)
    {
        /* //First, make space for the new Animal:
         Array.Resize(ref animals, animals.Length+1);
         //Then, put it into the new space that was created at the end of the Array:
         //Since we start counting at 0, we need to subtract 1.
         // animals[animals.Length - 1] = animal;
         animals[^1] = animal; //^1 is the same as animals.Length - 1*/
        
        
        this.animals.Add(animal);
        //Lista Fish
        //Förta - Salmon
        //Andra - ClownFish
        //tredje - Salmon


        /*for (int i = 0; i < this.animals.Count; i++)
        {
            Console.WriteLine(this.animals[i]);
        }*/
    }

    internal bool HasAnimal<TSpecies>() where TSpecies : TAnimal
    {
        //TSpecies == ClownFish
        //TAnimal == Fish
        /*var test = typeof(TSpecies);
        foreach(var variable in animals)
        {*/
        //skrivs ut;:
        //variable - Salmon
        //variable - Clownfish
        //variable - Salmon

        //Kolla om TSpecies finns i aniamls
        /*if(variable.Equals()/*TSpecies == variable)*/
        /*{
            return true;
        }*/
        /*if(variable == test)
        {
            Console.WriteLine("FEK");
        }
    }*/
        for (int i = 0; i < animals.Count; i++)
        {
            if(animals[i] is TSpecies)
            {
                return true;
            }
        }
            

        //TODO return true/false, depending on whether any TAnimal in animals
        return false;
    }
}

public class Animal { }
public class Mammal : Animal { }
public class Bear : Mammal { }
public class Donkey : Mammal { }
public class Lion : Mammal { }
public class Fish : Animal { }
public class Salmon : Fish { }
public class Clownfish : Fish { }
public class Student { }