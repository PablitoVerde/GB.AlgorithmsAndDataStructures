using System;
using System.Collections.Generic;
using System.Text;

namespace GB.AlgorithmsAndDataStructures.Lesson5
{
    //Расширенный класс дерева. В расширении реализованы методы поиска
    public class NodeWithSearch<T> : Lesson4.Node<T>
    {
        /// <summary>
        /// Метод поиска узла по значению в ширину. Возвращается найденный узел
        /// </summary>
        /// <param Искомое значение в формате int="searchValue"></param>
        /// <returns></returns>
        public Lesson4.Node<T> searchBFS(int searchValue)
        {
            Lesson4.Node<T> result = null;

            Lesson4.Node<T> rootNode = this.GetRoot();

            var queue = new Queue<Lesson4.Node<T>>();

            queue.Enqueue(rootNode);

            while (queue.Count != 0)
            {
                var nodeValue = queue.Dequeue();

                if (nodeValue != null)
                {
                    if (Convert.ToInt32(nodeValue.Value) == searchValue)
                    {
                        Console.WriteLine($"Значение найдено: {searchValue}");
                        result = nodeValue;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Проверенное значение дерева {nodeValue.Value}");

                        if (nodeValue.Left != null)
                        {
                            queue.Enqueue(nodeValue.Left);
                        }
                        if (nodeValue.Right != null)
                        {
                            queue.Enqueue(nodeValue.Right);
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Метод поиска узла по значению в глубину. Возвращается найденный узел
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public Lesson4.Node<T> searchDFS(int searchValue)
        {
            Lesson4.Node<T> result = null;

            Lesson4.Node<T> rootNode = this.GetRoot();

            var stack = new Stack<Lesson4.Node<T>>();

            stack.Push(rootNode);

            while (stack.Count != 0)
            {
                var nodeValue = stack.Pop();

                if (nodeValue != null)
                {
                    if (Convert.ToInt32(nodeValue.Value) == searchValue)
                    {
                        Console.WriteLine($"Значение найдено: {searchValue}");
                        result = nodeValue;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Проверенное значение дерева {nodeValue.Value}");

                        if (nodeValue.Left != null)
                        {
                            stack.Push(nodeValue.Left);
                        }
                        if (nodeValue.Right != null)
                        {
                            stack.Push(nodeValue.Right);
                        }
                    }
                }
            }

            return result;
        }
    }
}
