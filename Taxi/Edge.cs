using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Формула вирахування довжини
namespace Taxi
{
    /// <summary>
    /// Представляє ребро графа
    /// </summary>
    class Edge
    {
        public readonly Pair<int> Start;
        public readonly Pair<int> Final;
        public int Length
        {
            get
            {
                //Формула довжини відрізку по координатам
                return 0;
            }
        }

        /// <summary>
        /// Конструктор, що створює ребро за заданими координатами
        /// Є перезаванження для підтримки як 4 int так і 2 об'єктів класу Coordinate 
        /// </summary>
        public Edge(Pair<int> S, Pair<int> F)
        {
            Start = S;
            Final = F;
        }
        public Edge(int startX, int startY, int finalX, int finalY)
        {
            Start[0] = startX;
            Start[1] = startY;
            Final[0] = finalX;
            Final[1] = finalY;
        }
    }
    ////////
}
