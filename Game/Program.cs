using Game.print;
using Game.minigames;
using Game.console;
using Game.dialoges;
using Game.Shops;
using Game.player;

namespace Game
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

            
            Console.WriteLine(Player.Money);

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

            Print.action(Text.action(6));
            Print.dialoge(Text.radio(3), "radio");
            Print.dialoge(Text.zenon(3), "zenon");
            Print.dialoge(Text.radio(4), "radio");
            Print.dialoge(Text.zenon(4), "zenon");
            Print.dialoge(Text.radio(5), "radio");
            Print.dialoge(Text.zenon(5), "zenon");
            Print.dialoge(Text.radio(6), "radio");
            Print.action(Text.action(7));
            Print.dialoge(Text.zenon(6), "zenon");
            Print.dialoge(Text.radio(7), "radio");
            Print.dialoge(Text.zenon(7), "zenon");
            Print.action(Text.action(8));
            Print.dialoge(Text.radio(8), "radio");
            Print.dialoge(Text.zenon(8), "zenon");
            Print.dialoge(Text.radio(9), "radio");
            Print.action(Text.action(9));
            Print.action(Text.action(9.1));
            Print.dialoge(Text.unknown(1),"unknown");
            Print.action(Text.action(10));

            Console.ReadKey(true);
        }
    }
}