using System;

namespace ZooOR
{
    public class Zoo<Z>
    {
        public Z AddType { get; set; }
    }

    public class Animal
    {
        public void AddAnimal(Animal Z)
        {

        }
    }
   

    public class Mammal : Animal
    {
        
    }
    public class Beer : Animal
    {
        
    }
    public class Donkeh : Animal
    {
        
    }
    public class Simba : Animal
    {
        
    }
    public class FishnChips : Animal
    {
        
    }
    public class Salmonella : FishnChips
    {
        
    }
    public class Nemo : FishnChips
    {
        
    }

    public class StudenteAldente
    {
        
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Nemo nemo = new Nemo();
            Zoo<FishnChips> fishyZoo = new Zoo<FishnChips>();
            Zoo<Mammal> mammies = new Zoo<Mammal>();
            Zoo<Donkeh> duncans = new Zoo<Donkeh>();

            fishyZoo.AddType = nemo;
        }
    }
}
