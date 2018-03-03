using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiExceptions;
// throw new Exception();//болванка
namespace Taxi
{
    /// <summary>
    /// Представляє неорієнтований граф
    /// </summary>
    class Graph
    {
        //Поля
        /// <summary>
        /// Список(словник) суміжності
        /// В якості ключа виступає вузол, а в якості значень список сусідів данного вузла
        /// </summary>
        private Dictionary<Node, List<Node>> adjacency_list;
        /// <summary>
        /// Список(словник) ребер
        /// В якості ключа виступає пара вузлів, а в якості значень ребро
        /// </summary>
        private Dictionary<Pair<Node>, Edge> edge_list;

        //Властовисті
        public int NodeCount { get; } //повертає кількість вузлів
        public int EdgeCount { get; } //повертає кількість ребер

        //Індексатори
        /// <summary>
        /// Індексатор , що дозволяє:
        /// 1. Отримати список сусідніх вузлів до данного вузла
        /// 2. Створювати новий запис у списку сужіності у форматі (вузол, список сусідів)
        /// </summary>
        /// <param name="node">Вузол для якого хочемо отримати список суміжності, або для якого хочемо його створити</param>
        /// <exception cref="WrongNodeReferenceException" />
        /// <returns>Список сусідів вузла</returns>
        public List<Node> this[Node node]
        {
            get
            {
                if (adjacency_list.ContainsKey(node))
                    return adjacency_list[node];
                throw new WrongNodeReferenceException("Неможливо знайти вершину з такими даними");
            }
            set
            {
                if (adjacency_list.ContainsKey(node))
                    throw new WrongNodeReferenceException("Неможливо знайти вершину з такими даними");
                adjacency_list.Add(node, value);
            }
        }
        /// <summary>
        /// Індексатор , що дозволяє:
        /// 1. Отримати список сусідніх вузлів до данного вузла по його номеру
        /// 2. Створювати новий запис у списку сужіності у форматі (вузол, список сусідів)
        /// </summary>
        /// <param name="nodeID">Номмер вузла для якого хочемо отримати список суміжності, або для якого хочемо його створити</param>
        /// <exception cref="WrongNodeReferenceException" />
        /// <returns>Список сусідів вузла</returns>
        public List<Node> this[int nodeID]
        {
            get
            {
                Node node = GetNodeByID(nodeID);
                if (node != null)
                    return adjacency_list[node];
                throw new WrongNodeReferenceException("Неможливо знайти вершину з такими даними");
            }
            set
            {
                Node node = GetNodeByID(nodeID);
                if (node != null)
                    adjacency_list.Add(node, value);
                else
                    throw new WrongNodeReferenceException("Неможливо знайти вершину з такими даними");
            }
        }
        /// <summary>
        /// Індексатор , що дозволяє:
        /// 1. Отримати ребро за парою вузлів, які він об'єднує. Якщо такого з'єдання не існує , то повертає 
        /// 2. Створювати новий запис у списку ребер у форматі (пара вузлів, ребро)
        /// </summary>
        /// <param name="nodePair">Пара вузлів для якого хочемо отримати ребро, або для якого хочемо його створити</param>
        /// <exception cref="WrongNodeReferenceException" />
        /// <exception cref="WrongEdgeLengthException" />
        /// <returns>Ребро</returns>
        public Edge this[Pair<Node> nodePair]
        {
            get
            {
                if (edge_list.ContainsKey(nodePair))
                    return edge_list[nodePair];
                throw new WrongNodeReferenceException("Дані вершини не є сусідніми");
            }
            set
            {
                if (edge_list.ContainsKey(nodePair))
                    throw new WrongNodeReferenceException("Дані вершини не є сусідніми");
                if (value.Length <= 0)
                    throw new WrongEdgeLengthException("Довжини ребер не можуть мати від'ємні значення");
                edge_list.Add(nodePair, value);
            }
        }
        //Конструктори   
        /// <summary>
        /// Оболочний конструктор
        /// </summary>
        public Graph()
        {
        }

        //Методи
        /// <summary>
        /// Знаходить і повертає посилання на вузол по його номеру
        /// </summary>
        /// <param name="nodeID">номер вузла</param>
        /// <returns>Вузол - якщо ID правильне</returns>
        /// <returns>null - якщо ID неправильне</returns>
        public Node GetNodeByID(int nodeID)
        {
            foreach (Node item in adjacency_list.Keys)
                if (item.Number == nodeID)
                    return item;
            return null;
        }

    }
}