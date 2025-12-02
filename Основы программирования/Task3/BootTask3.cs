using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Основы_программирования.Task3
{
    internal class BootTask3
    {
        private string name;
        private int age;
        private string zodiac;
        private string company;

        public void Run()
        {
            // "Вас зовут Алексей, вам 21, вы водолей и работаете на заводе." Задать вопросы

            Console.Write("Как вас зовут?");
            name = Console.ReadLine();

            Console.Write("Сколько Вам лет?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ваш знак зодиака?");
            zodiac = Console.ReadLine();

            Console.Write("Где вы работаете?");
            company = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age}, вы {zodiac} и работаете {company}");
        }
    }
}
