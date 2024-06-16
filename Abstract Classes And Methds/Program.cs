using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class Program { 

    // Main method
    public static void Main(string[] args)
    {
        Circle myCircle = new Circle { Radius = 5 };
        Rectangle myRectangle = new Rectangle { Width = 4, Height = 6 };

        Console.WriteLine(myCircle.GetArea());      // Outputs the area of the circle
        Console.WriteLine(myRectangle.GetArea());   // Outputs the area of the rectangle
    }
}