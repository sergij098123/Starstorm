using System.Media;
using System.Xml;
using Game;
using Game.print;
using Game.minigames;
using Game.console;
using Game.cheat;
using Game.dialoges;

namespace Program
{
    static class Program
    {
        static void Main() 
        {   
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Click to start:");
            Console.ReadKey(true);
            MyConsole.ClearLine(1);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            //const int CnsWidth = Console.WindowWidth;
            //const int CnsHeight = Console.WindowHeight;

            Print.dialoge(Text.zenon(1),"zenon");
            Print.action(Text.action(1));
            Print.action(Text.action(2));
            Print.dialoge("Зеноне, ти в порядку? Ти з нами? Система життєзабезпечення працює, але ми вийшли з орбiти. Зоряний Вихор змiнив" +
                " усi \n навколишнi поля. Це не просто аномалiя... твої органи зору, схоже, теж пошкодженi.", "radio");
            Print.action("Зенон важко пiдводиться i починає рухатися по кораблю, намагаючись знайти потрiбнi системи для ремонту. Вiн може \n бачити лише певнi контури, але деталей не вистачає для повної орiєнтацiї.");
                
            Print.dialoge("Я... я бачу лише обриси. Щось рухається в темрявi. Що це? Як я можу розiбратися в цьому?", "zenon");
            Print.action("Далеко чути звуки ламаючогося металу. Зенон iнтуїтивно наближається до джерела шуму.");
            
            Print.dialoge("Це корабель, Зенон. Вiн зламаний. Ти маєш обережно рухатися по борту, бо частина корабля вже руйнується. У тебе є \n лише обмежена кiлькiсть часу, щоб знайти ресурси та забезпечити безпеку.", "radio");
            Print.action("Зенон продовжує шукати вихiд з цiєї ситуацiї, використовуючи свої залишковi можливостi бачити обриси, орiєнтуватися на \n звуки та сенсори. Ще частково залишаються контури планет, якi вiн може бачити через \n вiкно корабля, але вони дуже розмитi.");

            minigame1.choiсe();

            Console.ReadKey(true);
        }
    }
}