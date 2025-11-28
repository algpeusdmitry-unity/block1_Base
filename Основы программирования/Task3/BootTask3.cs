using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Основы_программирования.Task3
{
    internal class BootTask3
    {
        public void Run()
        {
            // "Вас зовут Алексей, вам 21, вы водолей и работаете на заводе." Задать вопросы

            Console.Write("Как вас зовут?");
            string name = Console.ReadLine();

            Console.Write("Сколько Вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ваш знак зодиака?");
            string zodiac = Console.ReadLine();

            Console.Write("Где вы работаете?");
            string company = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age}, вы {zodiac} и работаете {company}");
        }
    }
}
