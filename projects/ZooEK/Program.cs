using System;

namespace ZooEK
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear();
            Donkey donkey = new Donkey();
            Lion lion = new Lion();
            Clownfish clownfish = new Clownfish();
            Salmon salmon = new Salmon();
            Zoo<Mammal> animalZoo = new Zoo<Mammal>();
            Zoo<Fish> fishZoo = new Zoo<Fish>();
            Zoo<Donkey> donkeyZoo = new Zoo<Donkey>();


            animalZoo.AddObject = bear;
            animalZoo.AddObject = donkey;
            animalZoo.AddObject = lion;

            donkeyZoo.AddObject = donkey;

            fishZoo.AddObject = clownfish;
            fishZoo.AddObject = salmon;
        }
    }

  
}

public class Zoo<T>
{
    public T AddObject { get; set; }

    public T HasObject { get; set; }
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