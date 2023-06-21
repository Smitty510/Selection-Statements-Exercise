using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            var r = new Random();
            var favNumber = r.Next(0, 1001);
            int userInput;
            var counter = 0;

            Console.WriteLine("Pick a number from 1 - 1000");
            userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if (userInput > favNumber)
            { 
                Console.WriteLine($"{userInput} is too high");
            }
            else 
            {
                Console.WriteLine("You've guessed it!");
            }

            counter++;

            Console.WriteLine($"You have guessed {counter} times");

            while (userInput != favNumber) ;
        
        }   
         
               
            
    }
}
