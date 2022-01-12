using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoritenumber = 3;

            Console.WriteLine("Guess the favorite numbe. Hint: below 10");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess > favoritenumber)
            {
                Console.WriteLine("Too High!!!!");
            }
            else if (userGuess < favoritenumber)
            {
                Console.WriteLine("Too Low!!");
            }
            else if (userGuess == favoritenumber) 
            {
                Console.WriteLine("you are right");
            }
            else
            {
                Console.WriteLine("Never mind");
            }

            string subject = "c#";
            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();

            switch(userSubject)
            {
                case "C#":
                Console.WriteLine("you are in the right class");
                    break;

                case "Java":
                    Console.WriteLine("C# is better than Java");
                    break;

                default:
                    Console.WriteLine("We teach coding here");
                    break; 
            }

        }
    }
}
