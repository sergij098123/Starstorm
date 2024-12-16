using Game.print;
using Game.minigames;
using Game.console;
using Game.text;
using Game.Shops;
using Game.player;
using Game.selects;
using Game.parts; // Імпортування інших файлів
#pragma warning disable CS8601 //// Possible null reference assignment.
// Я використувую такі плагіни:
// Better Comments
// exe Runner
// git Graph

namespace Game
{
    static class Program
    {
        static public string choose = "null"; // створення "choose"
        static void Main() 
        {   
            
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Ставлення кодування на utf 8
            Console.WriteLine("Click to start:");
            choose = Console.ReadLine(); // * Якщо ввести "skip" при запуску можна пропустити більшу частину гри
            MyConsole.ClearLine(1);
            Random random = new Random(); // TODO створення random на майбутьне
            
            if(choose != "skip"){
                Part1.main();
            }

            Print.dialoge(" ×The end of game× ", "game"); // * Кінец гри
        }
    }
}