using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Основы_программирования.Task7
{
    internal class BootTask7
    {
        private int peopleCount;
        private const int receptionTime = 10;
        private const int hour = 60;

        public void Run()
        {
            // Вы заходите в поликлинику и видите огромную очередь из пациентов, вам нужно рассчитать время ожидания в очереди.

            Console.Write("Введите кол-во пациентов: ");
            peopleCount = Convert.ToInt32(Console.ReadLine());

            int hours = (peopleCount * receptionTime) / hour;
            int minutes = peopleCount * receptionTime - hours * hour;

            Console.Write($"Вы должны отстоять в очереди {hours} часа и {minutes} минут.");

            // update
        }
    }
}
