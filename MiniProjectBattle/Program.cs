using System;
using System.Collections.Generic;

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
    }
}
