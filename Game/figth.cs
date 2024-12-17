using Game;
using Game.print;
using Game.minigames;
using Game.console;
using Game.text;
using Game.Shops;
using Game.selects;
using Game.parts;
using Game.statistic;

namespace Game.figth{
    public static class Figth{
        public static void enemy(string name){
            var hp = Stat.Player.HP;
            var damage = Stat.Player.Weapon.Damage;
            var enemy_hp = Stat.Enemy.hp(name);
            var enemy_damage = Stat.Enemy.damage(name);

            while(true){
                Console.ReadKey();
                if(hp <= 0 ){
                    Console.WriteLine("\nYou loose!");
                    break;
                }
                if(enemy_hp <= 0){
                    Console.WriteLine("\nYou win");
                    break;
                }
                hp -= enemy_damage;
                Console.WriteLine($"HP: {hp}");
                Console.ReadKey();

                enemy_hp -= damage;
                Console.WriteLine($"Enemy HP: {enemy_hp}");
            }
        }
    }
}