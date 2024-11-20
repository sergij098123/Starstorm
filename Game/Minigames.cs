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
                    minigame1.heath();
                    systems[2] = true;
                    break;
                default:
                    Console.WriteLine("Введіть правильне значення!");
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
        public static void heath(){
            Console.WriteLine("Полагодте систему життєзабезпечення");

            Random random = new Random();
        bool systemRepaired = false;
        //int attempts = 5; // Кількість спроб для гравця

        Console.WriteLine("⚠️ Поломка системи життєзабезпечення! ⚠️");
        //Console.WriteLine("Ви маєте відремонтувати її за 5 кроків, інакше корабель буде втрачено.\n");

        // Цикл для спроб
        while (!systemRepaired)
        {
            //Console.WriteLine($"Залишилось спроб: {attempts}");
            Console.WriteLine("Виберіть дію:");
            Console.WriteLine("1. Перевірити кабелі");
            Console.WriteLine("2. Перезапустити систему");
            Console.WriteLine("3. Змінити резервний запобіжник");
            Console.WriteLine("4. Затягнути з'єднання трубопроводу");
            Console.WriteLine("5. Відправити сигнал SOS");

            // Введення дії від гравця
            Console.Write("Ваш вибір: ");
            int choice;
            bool isValid = int.TryParse(Console.ReadLine(), out choice);

            if (!isValid || choice < 1 || choice > 5)
            {
                Console.WriteLine("⛔ Неправильна дія! Спробуйте ще раз.\n");
                continue;
            }

            // Симуляція перевірки дії
            int correctAction = random.Next(1, 5); // Генеруємо правильний крок
            if (choice == correctAction)
            {
                systemRepaired = true;
                Console.WriteLine("\n✅ Ви успішно відремонтували систему життєзабезпечення! Корабель врятовано.");
            }
            else
            {
                Console.WriteLine("❌ Ця дія не допомогла. Проблема залишається.");
                //attempts--;
            }

            Console.WriteLine();
            Thread.Sleep(1000); // Додаємо паузу для більшого драматизму
        }

        //if (!systemRepaired)
        //{
        //    Console.WriteLine("💥 Ви не змогли відремонтувати систему. Корабель втратив життєзабезпечення...");
        //}

        Console.WriteLine("\nСистему життєзабезпечення полагоджена!");
        }
    }
}