using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    // Main method
    public static void Main(string[] args)
    {
        IMovable myCar = new Car();
        IMovable myBicycle = new Bicycle();

        myCar.Move();      // Outputs "Car is moving"
        myBicycle.Move();  // Outputs "Bicycle is moving"
    }
}