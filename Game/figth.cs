using Game;
using Game.print;
using Game.minigames;
using Game.console;
using Game.text;
using Game.Shops;
using Game.selects;
using Game.parts;
using Game.statistic;
using Game.random;

namespace Game.figth{
    public static class Figth{
        public static void enemy(string name){
            var hp = Stat.Player.HP;
            var damage = Stat.Player.Weapon.Damage;
            var enemy_hp = Stat.Enemy.hp(name);
            var enemy_damage = Stat.Enemy.damage(name);
            var randomAtack = GRandom.random.Next(-1,1);
            int i = 0;
            byte spare = 0;
            string input;

            Console.WriteLine($"Характеристики {name}:\nHP: {enemy_hp}\nУрон: {enemy_damage}");



            while(true){
                Console.ReadKey();
                if(hp <= 0 ){
                    Console.WriteLine("\nYou loose!");
                    break;
                }
                if(enemy_hp <= 0){
                    Console.WriteLine($"\nYou win\nYou earn {i} stardust");
                    Stat.Player.Money += i;
                    break;
                }
                if(spare >= 100){
                    Console.WriteLine($"\nYou win\nYou earn {i}");
                    Stat.Player.Money += i;
                    break;
                }

                Console.WriteLine("1.Атакувати\n2.Пощядити\nзбіжати");
                input = Console.ReadLine();
                switch(input){
                    case "1":
                    case "a":
                    case "а":
                        enemy_hp -= damage + randomAtack;
                        Console.WriteLine($"Enemy HP: {enemy_hp}");
                        break;
                    case "2":
                    case "s":
                    case "п":
                    case "щ":
                        spare += 20;
                        break;
                    default: break;
                }

                randomAtack = GRandom.random.Next(-1,1);
                hp -= enemy_damage + randomAtack;
                Console.WriteLine($"HP: {hp}");
                randomAtack = GRandom.random.Next(-1,1);

                i++;
            }
        }
    }
}