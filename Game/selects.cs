using Game.print;
using Game.minigames;
using Game.console;
using Game.dialoges;
using Game.Shops;
using Game.player;
using System.Security.Cryptography.X509Certificates;
namespace Game.selects{
    public static class part1{
        public static bool choose = true;
        public static void main(){
            string input;
            Console.WriteLine("1.Так\n2.Ні");
            while (choose){
                input = Console.ReadLine();
                if(input == "1"){
                    part1.choose = false;
                    break;
                } 
                else if(input == "2"){
                    part1.choose = true;

                    Print.dialoge(Text.game(1), "game");
                    Print.dialoge(Text.game(2), "game");
                    Console.Beep();
                    Thread.Sleep(1000);
                }
                else {
                    Print.dialoge("Що ти сказав? Повтори.", "unknown");
                }
            }
            Print.dialoge(Text.zenon(12), "zenon");
            Print.action(Text.action(16));
            Print.dialoge(Text.radio(11), "radio");
            Print.action(Text.action(17));
            Print.dialoge(Text.unknown(5), "unknown");
            Print.action(Text.action(18));
        }
    }
}