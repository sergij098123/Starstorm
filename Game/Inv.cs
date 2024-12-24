using Game.Items;

namespace Game.Inventory{
    class Inv{
        public string Name { get; set; } = string.Empty; // Назва предмета
        public int Damage { get; set; } = 0; // Стат для предметів типу "зброя"
        public double Protection { get; set; } = 0.0; // Стат для предметів типу "захист"
        public int Repair { get; set; } = 0; // Стат для предметів типу "ремонт"

        public static List<Item> Items = new List<Item>();
    }
}