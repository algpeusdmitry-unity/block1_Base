using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Основы_программирования.Task7
{
    internal class BootTask7
    {
        public void Run()
        {
            // Вы заходите в поликлинику и видите огромную очередь из пациентов, вам нужно рассчитать время ожидания в очереди.

            int peopleCount;
            const int receptionTime = 10;
            const int hour = 60;
            int hours;
            int minutes;

            Console.Write("Введите кол-во пациентов: ");
            peopleCount = Convert.ToInt32(Console.ReadLine());

            hours = (peopleCount * receptionTime) / hour;
            minutes = peopleCount * receptionTime - hours * hour;

            Console.Write($"Вы должны отстоять в очереди {hours} часа и {minutes} минут.");

            // update
        }
    }
}
