using System;
using Custom;
namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your favorite subject in school?");
            string input = User.GetInput().ToLower();
            UI.Spacer();

            switch (input)
            {
                case "math":
                    Console.WriteLine("We aren't going to be friends.");
                    break;
                case "english":
                    Console.WriteLine("I'm lucky if I can even spell something right.");
                    break;
                case "history":
                    Console.WriteLine("I can never remember all those events. I think I actually failed that class.");
                    break;
                case "science":
                    Console.WriteLine("You must like blowing things up. I like the way you think");
                    break;
                case "women":
                    Console.WriteLine("NARLEY DUUUUUDE! THATS MY FAVORITE TOO!");
                    break;
                default:
                    Console.WriteLine("I've never heard of that class before. Seems like fun though.");
                    break;
            }

            UI.ExitProgram();
        }
    }    
}
