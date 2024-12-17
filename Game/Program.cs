using Game.print;
using Game.minigames;
using Game.console;
using Game.text;
using Game.Shops;
using Game.selects;
using Game.parts;
using Game.figth; // Імпортування інших файлів
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
        public static void Main() 
        {   
            
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Ставлення кодування на utf 8
            Console.WriteLine("Click to start:");
            choose = Console.ReadLine(); // * Якщо ввести "skip" при запуску можна пропустити більшу частину гри
            MyConsole.ClearLine(1);

            Figth.enemy("test");
            
            if(choose != "skip"){
                Part1.main();
            }

            Print.dialoge(" ×The end of game× ", "game"); // * Кінец гри
        }
    }
}