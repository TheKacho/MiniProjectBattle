using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniProjectBattle
{
    public class MainGameConsole
    {
        public static List<string> punch = new List<string>()
        {
            "P U N C H !"
        };

        public static List<string> block = new List<string>()
        {
            "B L O C K !"
        };

        public static List<string> kick = new List<string>()
        {
            "K I C K !"
        };

        public static List<KeyValuePair<string, string>> mainMenu = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("P", "Punch"),
            new KeyValuePair<string, string>("K", "Kick"),
            new KeyValuePair<string, string>("B", "Block"),
            new KeyValuePair<string, string>("Q", "Quit");

        }

        public static string PrintResult(bool displayWinLose, string cpuChoice)
        {
            return (displayWinLose) ? "You have won the match!" : $" The Computer has won the match!"
        }

        public static void MainConsole()
    {
        ConsoleKeyInfo userInput;
        do
        {
            Random RandoNum = new Random();
            KeyValuePair<string, string> cpuInput = mainMenu.ElementAt(randomNum.Next(mainMenu.count - 1));
            Console.WriteLine("Welcome to the DOJO!");
            Console.WriteLine("Your choices are displayed on the screen.");
            Console.WriteLine("Please choose one of the following or press Q to leave the DOJO.");

            foreach (KeyValuePair<string, string> option in mainMenu)
            {
                Console.WriteLine($"{option.Key} {option.Value}");
            }
        }
    }
    }
}
