using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Основы_программирования.Task4
{
    internal class BootTask4
    {
        private const int picturesPerRow = 3;
        private int totalPictures = 52;
        private int fullRows;
        private int overPictures;

        public void Run()
        {
            // На экране, в специальной зоне, выводятся картинки, по 3 в ряд (условно, ничего рисовать не надо). Всего у пользователя в альбоме 52 картинки.
            // Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.

            fullRows = totalPictures / picturesPerRow;
            overPictures = totalPictures - (fullRows * picturesPerRow);
            Console.WriteLine($"Полностью заполненных рядов: {fullRows}");
            Console.WriteLine($"Картинок сверх меры: {overPictures}");
        }
    }
}
