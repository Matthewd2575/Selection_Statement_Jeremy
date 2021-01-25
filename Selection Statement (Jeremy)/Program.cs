using System;

namespace Selection_Statement__Jeremy_
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine($"Guess a number between 1-10");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low.");
            }

            else if (userInput > favNumber)

            {
                Console.WriteLine($"{userInput} is too low.");
            }
            else

            { 
                Console.WriteLine($"NEVERMIND!"); 
            }
        
            


            
        }
    }
}
