using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; // Declaring the variable a

            a = 9 - 2; //Assigning a value to a, using some math
            a = 3 + 3; //Anoth assignment

            int b = 3 + 1; //Declaring b and assigning a value to b all at once
            b = 1 + 2; //Assigning a second value to b

            float totalCost = 22.54f;
            float tipPercent = 0.18f; //Remeber, this is the same as 18%
            float tipAmount = totalCost * tipPercent;

            double moneyMadeFromGame = 100000;
            double totalProgrammers = 4;
            double moneyPerPerson = moneyMadeFromGame / totalProgrammers; //We're rich!

            //The formula for the area of a circle is pi * r ^ 2
            float radius = 4;
            float pi = 3.1415926536f; //The 'f' makes it a float literal instead of a double literal
            float area = pi * radius * radius;

            //Using the + operator with strings results in "concatenation"
            Console.WriteLine("The area of the circle is " + area + ".");
        }
    }
}
