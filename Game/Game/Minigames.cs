using System.Runtime.InteropServices.Marshalling;
using Game.print;
using Game.console;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace Game.minigames
{
    public static class minigame1{
        public static void choiсe (){
            bool[] systems = {false,false,false,true};

            string input;

            while (systems[3]){
                Console.WriteLine("Виберiть, який модуль корабля вiдремонтувати:");
                Console.WriteLine("    1.Двигун");
                Console.WriteLine("    2.Навiгацiя");
                Console.WriteLine("    3.Життєзабезпечення");

                input = Console.ReadLine();

                switch (input)
                {
                case "1":
                case "Двигун":
                    minigame1.motor();
                    systems[0] = true;
                    break;
                case "2":
                case "Навiгацiя":
                    minigame1.navigation();
                    Console.WriteLine("Навiгацiя полагоджена!");
                    systems[1] = true;
                    break;
                case "3":
                case "Життєзабазпечення":
                    //minigame1.heath();
                    Console.WriteLine("Системи життєзабазпечення полагодженнi!");
                    systems[2] = true;
                    break;
                }
                if (systems[0]) {
                    if (systems[1]) {
                        if (systems[2])
                            systems[3] = false;
                    }
                }
            }
            Console.WriteLine("Всi системи полагодженнно!");
        }
        public static bool motor()
        {
            Console.WriteLine("Натискайте [Enter], щоб запустити двигун");
            MyConsole.ProgressBar();

            Console.WriteLine("\nДвигун запущенно!");
            Thread.Sleep(1500);
            return true;
        }
        public static void navigation(){
            Console.WriteLine("Вiдкалiбруйте систему навiгацiї:");
            MyConsole.calibration();
        }
    }
}