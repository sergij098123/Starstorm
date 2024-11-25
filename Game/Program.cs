using System.Media;
using System.Xml;
using Game;
using Game.print;
using Game.minigames;
using Game.console;
using Game.dialoges;

namespace Program
{
    static class Program
    {
        static void Main() 
        {   
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Click to start:");
            Console.ReadKey(true);
            MyConsole.ClearLine(1);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            //const int CnsWidth = Console.WindowWidth;
            //const int CnsHeight = Console.WindowHeight;

            Print.dialoge(Text.zenon(1),"zenon");
            Print.action(Text.action(1));
            Print.action(Text.action(2));
            Print.dialoge(Text.radio(1), "radio");
            Print.action(Text.action(3));
            Print.dialoge(Text.zenon(2), "zenon");
            Print.action(Text.action(4));
            Print.dialoge(Text.radio(2), "radio");
            Print.action(Text.action(5));

            minigame1.choiсe();

            Console.ReadKey(true);
        }
    }
}