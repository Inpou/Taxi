using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Taxi
{
    class Pair<T>
    {
        private T first;
        private T second;
        public T this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return first;
                    case 1: return second;
                    default:
                        throw new IndexOutOfRangeException("Ви вийшли за межі вимірів координат");
                }
            }
            set
            {
                switch (i)
                {
                    case 0:
                        first = value;
                        break;
                    case 1:
                        second = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Ви вийшли за межі вимірів координат");
                }
            }
        }

        public Pair(T first, T second)
        {
            try
            {
                this[0] = first;
                this[1] = second;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Помилка", MessageBoxButtons.OK);
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(e.Message, "Помилка", MessageBoxButtons.OK);
            }
        }
        public Pair() : this(default, default) { }
        public Pair(Pair<T> P) : this(P[0], P[1]) { }

        public override string ToString()
        {
            return "(" + first.ToString() + "," + second.ToString() + ")";
        }
    }
}
