using Game.print;
using Game.minigames;
using Game.console;
using Game.text;
using Game.Shops;
using Game.selects;
using Game.parts;
using System.ComponentModel;

namespace Game.statistic{
    public static class Stat{
        public class Enemy{
            public static int hp(string name){
                switch(name){
                    case "test":
                        return Player.HP / 2;
                    default:
                        Console.WriteLine("SyntaxCheck error: wrong ID");
                        return -1;
                    }
            }
            public static int damage(string name){
                switch(name){
                    case "test":
                        return Player.Weapon.Damage / 2;
                    default:
                        Console.WriteLine("SyntaxCheck error: wrong ID");
                        return -1;
                    }
            }
        }
        static public class Player{ // TODO Потрібна система бою
        static public int Money = 10;
        static public class Weapon{
            static public string Name = "wrench";
            static public int Damage = 2;
        }
        static public class Armor{
            static public string Name = "cosmic suit";
            static public double Protection = 0.5;
        }
        public const string Name = "Zenon";
        public const string Surname = "Helx";
        public const int HP = 20;
    }
    }
}