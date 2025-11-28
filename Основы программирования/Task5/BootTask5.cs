using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Основы_программирования.Task5
{
    internal class BootTask5
    {
        public void Run()
        {
            // Даны две переменные. Поменять местами значения двух переменных. Вывести на экран значения переменных до перестановки и после.

            string name = "Альгпеус";
            string surname = "Дмитрий";
            Console.WriteLine($"Ваше имя {name} и Ваша фамилия {surname}");

            string temp = name;
            name = surname;
            surname = temp;
            Console.WriteLine($"Ваше имя {name} и Ваша фамилия {surname}");

            // Тут пришлось через чатгпт смотреть способ и читать про temp, в видео не нашёл, где текстовые значения меняют в первом часу.
        }
    }
}
