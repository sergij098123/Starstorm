using Game;
using Game.print;
using Game.minigames;
using Game.console;
using Game.dialoges;
using Game.Shops;
namespace Game.player{
    static public class Player{
        static public int Money = 10;
        static public class Weapon{
            static public string Name = "wrench";
            static public double Damage = 2;
        }
        static public class Armor{
            static public string Name = "cosmic suit";
            static public double Protection = 0.5;
        }
        public const string Name = "Zenon";
        public const string Surname = "Helx";
        public const double HP = 20;
    }
}