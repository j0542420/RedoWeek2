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
                Console.WriteLine("Enter a number 1 - 4 to run witch project");
                double choice = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                { 
                    case 1:
                        Console.WriteLine("You chose project 1");
                        Project1 project1 = new Project1();
                        project1.Run();
                        break;
                    case 2:
                        Console.WriteLine("You chose project 2");
                        Project2 project2 = new Project2();
                        project2.Run();
                        break;
                    case 3:
                        Console.WriteLine("You chose project 3");
                        Project3 project3 = new Project3();
                        project3.Run();
                        break;
                    case 4:
                        Console.WriteLine("You chose project 4");
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

                Console.WriteLine("What is the Principal amount of loan in dollars");
            }
        }
    }
}
