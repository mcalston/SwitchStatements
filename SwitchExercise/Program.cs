using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What's your favorite subject?");
            var response = Console.ReadLine();

            switch (response)
            {
                case "Art":
                    Console.WriteLine($"Art is fun!");
                    break;
                case "English":
                    Console.WriteLine("That's cool but I cannot read");
                    break;
                case "Science":
                    Console.WriteLine("A bit complicated, but important to know");
                    break;
                case "Math":
                    Console.WriteLine("I HATE math with a passion");
                    break;
                case "Gym":
                    Console.WriteLine("Gotta get that exercise going!");
                    break;
                default:
                    Console.WriteLine("Never heard of that one");
                    break;
            }
        }
    }
}
