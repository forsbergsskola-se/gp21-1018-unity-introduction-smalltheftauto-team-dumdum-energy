using System;

namespace ZooEK
{
    class Program
    {
        string[] AnimalZooz = new string[4];
        static void Main(string[] args)
        {
            Bear bear = new Bear();
            Zoo<Bear> animalZoo = new Zoo<Bear>();

            Zoo<Donkey> donkeyZoo = new Zoo<Donkey>();

            

           /*
            Zombie zombie = new Zombie();
            Trap<Zombie> zombieTrap = new Trap<Zombie>();
            zombieTrap.Activate(zombie);
           */


        }
    }
  
}

public class Zoo<T>
{
   public T AddObject { get; set; }
}
public class Animal
{
    public void AddAnimal(Donkey T)
    {

    }
}
public class Mammal : Animal { }
public class Bear : Mammal { }
public class Donkey : Mammal { }
public class Lion : Mammal { }
public class Fish : Animal { }
public class Salmon : Fish { }
public class Clownfish : Fish { }
public class Student { }