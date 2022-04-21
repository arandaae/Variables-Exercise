using System;

namespace VariableExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare and initialize variables for the following types
            string name = "Armando";
            int myAge = 30;
            char firstLetterOfLastName = 'A';
            bool completedExercise = true;
            double testDouble = 1.1;
            decimal testDecimal = 2.2M;

            Console.WriteLine($"My name is {name}, my age is {myAge} years old.");

            Console.WriteLine($"The first letter of my last name is {firstLetterOfLastName} .");

            Console.WriteLine($"This is an example of a double {testDouble}.");

            Console.WriteLine($"This is an example of a decimal {testDecimal}.");

            Console.WriteLine("I have completed this exercise");
            Console.WriteLine(completedExercise);
            

            
            
        }
    }
}
