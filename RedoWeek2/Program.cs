using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoWeek2
{
    internal class Program
    {
        // The main place to run the program
        static void Main(string[] args)
        {
            // using a while loop to run the program until the user chooses to exit
            while (true) 
            {
                // Displaying the menu to the user
                Console.WriteLine("Enter a number 1 - 4 to run witch Exercise, 5 to EXIT");
                // user inputs their choice of Exercise
                double choice = Convert.ToDouble(Console.ReadLine());

                // using a switch statement to run the Exercise based on the users choice
                switch (choice)
                {
                    // case 1 is for Exercise 1
                    case 1:
                        // letting the user know which Exercise they chose
                        Console.WriteLine("You chose to run Exercise 1");
                        // creating an instance of the Wk2Ex1 class and calling the Run1 method
                        Wk2Ex1 Wk2Ex1 = new Wk2Ex1();
                        Wk2Ex1.Run1();
                        break;
                    case 2:
                        // letting the user know which Exercise they chose
                        Console.WriteLine("You chose to run Exercise 2");
                        // creating an instance of the Wk2Ex2 class and calling the Run2 method
                        Wk2Ex2 Wk2Ex2 = new Wk2Ex2();
                        Wk2Ex2.Run2();
                        break;
                    case 3:
                        // letting the user know which Exercise they chose
                        Console.WriteLine("You chose to run Exercise 3");
                        // creating an instance of the Wk2Ex3 class and calling the Run3 method
                        Wk2Ex3 Wk2Ex3 = new Wk2Ex3();
                        Wk2Ex3.Run3();
                        break;
                    case 4:
                        // letting the user know which Exercise they chose
                        Console.WriteLine("You chose to run Exercise 4");
                        Wk2Ex4 Wk2Ex4 = new Wk2Ex4();
                        // creating an instance of the Wk2Ex4 class and calling the Run4 method
                        Wk2Ex4.Run4();
                        break;
                    case 5:
                        // letting the user know they chose to exit
                        Console.WriteLine("You chose to EXIT");
                        return;
                    default:
                        // letting the user know that they made an invalid choice
                        Console.WriteLine("Invalid choice, please enter a number between 1 and 5");
                        break;
                }
            }
        }
        // creating class for Exercise 1
        class Wk2Ex1
        {
            // creating a method to run the Exercise 1
            public void Run1()
            {
                // The title for the program
                Console.WriteLine("Interest Calculator Program");
                Console.ReadLine();

                // asking the user to input the Principal amount
                Console.WriteLine("What is the Principal amount of loan in dollars? ");
                // user inputs the principal amount
                double principal = Convert.ToDouble(Console.ReadLine());

                // asking the user to input the interest rate
                Console.WriteLine("What is the interest rate (input 0.05 for 5%)? ");
                // user inputs the interest rate
                double interestRate = Convert.ToDouble(Console.ReadLine());

                // asking the user to input the period of loan in years
                Console.WriteLine("What is the period of loan in years? ");
                // user inputs the period of loan in years
                double period = Convert.ToDouble(Console.ReadLine());

                // calculating the interest using the formula: interest = principal * interestRate * period
                double interest = principal * interestRate * period;

                // displaying the results to the user
                Console.WriteLine("The Total interest of loan is : $" + interest+ ".");

                // spacing out the results with the next line
                Console.ReadLine();
            }
        }
        // creating class for Exercise 2
        class Wk2Ex2
        {
            // creating a method to run the Exercise 2
            public void Run2()
            {
                // Asking the user to input the length of the rectangle
                Console.WriteLine("Enter the length of the rectangle: ");
                // user inputs the length of the rectangle
                double length = Convert.ToDouble(Console.ReadLine());

                // Asking the user to input the width of the rectangle
                Console.WriteLine("Enter the width of the rectangle: ");
                // user inputs the width of the rectangle
                double width = Convert.ToDouble(Console.ReadLine());

                // calculating the area and perimeter of the rectangle
                double area = length * width;
                double perimeter = 2 * (length + width);

                // displaying the results to the user
                Console.WriteLine("The Results:");
                Console.WriteLine("The area of the rectangle is: " + area);
                Console.WriteLine("The perimeter of the rectangle is: " + perimeter);

                // spacing out the results with the next line
                Console.ReadLine();
            }
        }
        // creating class for Exercise 3
        class Wk2Ex3
        {
            // creating a method to run the Exercise 3
            public void Run3()
            {
                // The title for the program
                Console.WriteLine("Welcome to Temperature Converter");

                // asking the user to input the temperature in Celsius
                Console.WriteLine("Enter the temperature in Fahrenheit: ");
                // user inputs the temperature in Celsius
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                // converting the temperature from Fahrenheit to Celsius
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine(fahrenheit + "in Fahrenheit is equivalent to " + celsius.ToString("F2") + " Celsius.");

                // spacing out the results with the next line
                Console.ReadLine();
            }
        }
        // creating class for Exercise 4
        class Wk2Ex4
        {
            // creating a method to run the Exercise 4
            public void Run4()
            {
                // The title for the program
                Console.WriteLine("Welcome to the Hypotenuses Calculator!");

                // asking the user to input the length of the first side
                Console.WriteLine("Enter the length of the first side (a): ");
                // user inputs the length of the first side
                double a = Convert.ToDouble(Console.ReadLine());

                // asking the user to input the length of the second side
                Console.WriteLine("Enter the length of the second side (b): ");
                // user inputs the length of the second side
                double b = Convert.ToDouble(Console.ReadLine());

                // calculating the length of the hypotenuse using the Pythagorean theorem
                double c = Math.Sqrt(a * a + b * b);

                // displaying the results to the user
                // Fixing the invalid expression term '{' and formatting the output correctly
                Console.WriteLine("The length of the hypotenuse is: " + c.ToString("F2"));

                // thanking the user for using the program
                Console.WriteLine("Thank You for using the Hypotenuses Calculator!");

                // spacing out the results with the next line
                Console.ReadLine();
            }
        }
    }
}
