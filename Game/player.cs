using Game;
using Game.print;
using Game.minigames;
using Game.console;
using Game.text;
using Game.Shops;
namespace Game.player{
    static public class Player{ // TODO Потрібна система бою
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