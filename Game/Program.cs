using System.Media;
using System.Xml;
using Game;
using Game.print;
using Game.minigames;
using Game.console;
using Game.dialoges;
using Game.Shops;

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
            //Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

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

            Print.dialoge(Text.radio(3), "radio");
            Print.dialoge(Text.radio(4), "radio");
            Print.dialoge(Text.radio(5), "radio");
            Print.dialoge(Text.radio(6), "radio");
            Print.dialoge(Text.radio(7), "radio");
            Print.dialoge(Text.radio(8), "radio");
            Print.dialoge(Text.radio(9), "radio");
            Print.dialoge(Text.unknown(1),"unknown");

            Console.ReadKey(true);
        }
    }
}