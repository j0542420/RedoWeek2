using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoWeek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Enter a number 1 - 4 to run witch Excersise");
                double choice = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                { 
                    case 1:
                        Console.WriteLine("You chose Excersise 1");
                        Project1 project1 = new Project1();
                        project1.Run();
                        break;
                    case 2:
                        Console.WriteLine("You chose Excersise 2");
                        Project2 project2 = new Project2();
                        project2.Run();
                        break;
                    case 3:
                        Console.WriteLine("You chose Excersise 3");
                        Project3 project3 = new Project3();
                        project3.Run();
                        break;
                    case 4:
                        Console.WriteLine("You chose Excersise 4");
                        Project4 project4 = new Project4();
                        project4.Run();
                        break;
                }
            }
        }
        class Project1
        {
            public void Run()
            {
                Console.WriteLine("Interest Calculator Program");
                Console.ReadLine();

                Console.WriteLine("What is the Principal amount of loan in dollars? ");
                double principal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is the interest rate (input 0.05 for 5%)? ");
                double interestRate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is the period of loan in years? ");
                double period = Convert.ToDouble(Console.ReadLine());

                double interest = principal * interestRate * period;

                Console.WriteLine("The Total interest of loan is : $" + interest+ ".");
            }
        }

        class Project2
        {
            public void Run()
            {
                Console.WriteLine("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the width of the rectangle: ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = length * width;
                double perimeter = 2 * (length + width);

                Console.WriteLine("The Results:");
                Console.WriteLine("The area of the rectangle is: " + area);
                Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
            }
        }

        class Project3
        {
            public void Run()
            {
                Console.WriteLine("Welcome to Temperature Converter");
                Console.WriteLine("Enter the temperature in fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine(fahrenheit + "in fahrenheit is equivalent to " + celsius + " Celsius.");
            }
        }

        class Project4
        {
            public void Run()
            {
                Console.WriteLine("Welcome to the Hypotensus Calculator!");
                Console.WriteLine("Enter the length of the first side (a): ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the length of the second side (b): ");
                double b = Convert.ToDouble(Console.ReadLine());

                double c = Math.Sqrt(a * a + b * b);

                Console.WriteLine("The length of the hypotenuse is: " + c);
                Console.WriteLine("Thank You for using the Hypotensus Calculator!");
            }
        }
    }
}
