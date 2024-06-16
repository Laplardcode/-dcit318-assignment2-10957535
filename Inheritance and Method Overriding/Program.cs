using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main
         (string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.MakeSound();  // Outputs "Some generic sound"
        myDog.MakeSound();     // Outputs "Bark"
        myCat.MakeSound();     // Outputs "Meow"
    }
}