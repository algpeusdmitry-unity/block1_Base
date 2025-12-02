using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Основы_программирования.Task6
{
    internal class BootTask6
    {
        private int gold;
        private int crystals;
        private int crystalPrice = 10;

        public void Run()
        {
            // Вы приходите в магазин и хотите купить за своё золото кристаллы. В вашем кошельке есть какое-то количество золота, продавец спрашивает у вас, сколько кристаллов вы хотите купить?
            // После сделки у вас остаётся какое-то количество золота в кошельке и появляется какое-то количество кристаллов.

            Console.Write("Сколько у Вас золота? ");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько Вы хотите купить кристаллов по цене 10 золота за кристалл? ");
            crystals = Convert.ToInt32(Console.ReadLine());

            int goldInPocket = gold - crystals * crystalPrice;
            Console.Write($"Вы купили кристаллы и теперь у вас в кошельке {goldInPocket} золота и {crystals} кристаллов!");
        }
    }
}
