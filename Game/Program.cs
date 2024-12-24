using Game.print;
using Game.minigames;
using Game.console;
using Game.text;
using Game.Shops;
using Game.selects;
using Game.parts;
using Game.figth;
using Game.Inventory;
using System.Security;
using Game.statistic;
using Game.Items; // Імпортування інших файлів
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

            var items = Item.Items(); // Створення предметів
            Stat.Player.Weapon.Name = items[0].Name;
            Stat.Player.Weapon.Damage = items[0].Damage; // Встановлення початкової зброї
            Stat.Player.Armor.Name = items[1].Name;
            Stat.Player.Armor.Protection = items[1].Protection; // Встановлення початкової броні

            Console.WriteLine("Click to start:");
            choose = Console.ReadLine(); // * Якщо ввести "skip" при запуску можна пропустити більшу частину гри
            MyConsole.ClearLine(1);

            Inv.Items.Add(items[0]);
            
            if(choose != "skip"){
                Part1.main();
            }

            Print.dialoge(" ×The end of game× ", "game"); // * Кінец гри
        }
    }
}