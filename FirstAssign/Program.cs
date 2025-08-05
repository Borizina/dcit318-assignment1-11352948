using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MultiFunctionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== MAIN MENU =====");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator();
                        break;
                    case "2":
                        TicketPriceCalculator();
                        break;
                    case "3":
                        TriangleTypeIdentifier();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting application. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please choose between 1 and 4.");
                        break;
                }
            }
        }
           // 1. Grade Calculator
        static void GradeCalculator()
        {
            Console.Write("\nEnter your numerical grade (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    string letterGrade;
                    if (grade >= 90)
                        letterGrade = "A";
                    else if (grade >= 80)
                        letterGrade = "B";
                    else if (grade >= 70)
                        letterGrade = "C";
                    else if (grade >= 60)
                        letterGrade = "D";
                    else
                        letterGrade = "F";

                    Console.WriteLine($"Your letter grade is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
  // 2. Ticket Price Calculator
        static void TicketPriceCalculator()
        {
            Console.Write("\nEnter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age <= 12 || age >= 65)
                {
                    Console.WriteLine("Discounted Ticket Price: GHC7");
                }
                else
                {
                    Console.WriteLine("Regular Ticket Price: GHC10");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
         // 3. Triangle Type Identifier
        static void TriangleTypeIdentifier()
        {
            Console.Write("\nEnter side 1: ");
            bool valid1 = double.TryParse(Console.ReadLine(), out double side1);

            Console.Write("Enter side 2: ");
            bool valid2 = double.TryParse(Console.ReadLine(), out double side2);

            Console.Write("Enter side 3: ");
            bool valid3 = double.TryParse(Console.ReadLine(), out double side3);

            if (valid1 && valid2 && valid3 && side1 > 0 && side2 > 0 && side3 > 0)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive numbers for all sides.");
            }
        }
    }
}
        
