using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    /// <summary>
    /// Список для позначення станів зупинок - вільна(0), місце стоянки таксі(1), локація клієнта(2)
    /// </summary>
    enum PossibleStatuses : int { Empty, Taxi, Client };
    /// <summary>
    /// Представляє об'єкти графа - вузли
    /// Кожен вузол має наступні поля:
    ///     1. Стан - описує стан цього вузла(зупинки) (вільна зупинка, місце стоянки таксі, локація клієнта)
    ///     2. Номер - ідентифікатор вузла |readonly
    ///     3. Координати розміщення вузла на формі |readonly
    /// </summary>
    class Node
    {
        public int Status { get; set; }
        public readonly int Number;
        public readonly Pair<int> placement;

        /// <summary>
        /// Конструктор ,що створює вузол
        /// </summary>
        /// <param name="number">Номер вузла</param>
        /// <param name="left">Відступ зліва від екрана</param>
        /// <param name="top">Відступ справа від екрана</param>
        public Node(int number,int left, int top)
        {
            Number = number;
            placement[0] = left;
            placement[1] = top;
        }

       
    }
}
