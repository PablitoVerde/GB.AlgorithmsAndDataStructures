using System;
using System.Collections.Generic;
using System.Text;

namespace GB.AlgorithmsAndDataStructures.Lesson5
{
    //Расширенный класс дерева. В расширении реализованы методы поиска
    public class NodeWithSearch<T> : Lesson4.Node<T>
    {
        /// <summary>
        /// Статический метод поиска узла по значению в ширину. Возвращается найденный узел
        /// </summary>
        /// <param Узел дерева="nodeTree"></param>
        /// <param Искомое значение в формате int="searchValue"></param>
        /// <returns></returns>
        static public Lesson4.Node<int> searchBFS(Lesson4.Node<int> nodeTree, int searchValue)
        {
            Lesson4.Node<int> result = null;

            var queue = new Queue<Lesson4.Node<int>>();

            queue.Enqueue(nodeTree);

            while (queue.Count != 0)
            {
                var nodeValue = queue.Dequeue();

                if (nodeValue != null)
                {
                    if (nodeValue.Value == searchValue)
                    {
                        Console.WriteLine($"Значение найдено: {searchValue}");
                        result = nodeValue;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Проверенное значение дерева {nodeValue.Value}");

                        if (nodeTree.Left != null)
                        {
                            queue.Enqueue(nodeValue.Left);
                        }
                        if (nodeTree.Right != null)
                        {
                            queue.Enqueue(nodeValue.Right);
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Статический метод поиска узла по значению в глубину. Возвращается найденный узел
        /// </summary>
        /// <param name="nodeTree"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        static public Lesson4.Node<int> searchDFS(Lesson4.Node<int> nodeTree, int searchValue)
        {
            Lesson4.Node<int> result = null;

            var stack = new Stack<Lesson4.Node<int>>();

            stack.Push(nodeTree);

            while (stack.Count != 0)
            {
                var nodeValue = stack.Pop();

                if (nodeValue != null)
                {
                    if (nodeValue.Value == searchValue)
                    {
                        Console.WriteLine($"Значение найдено: {searchValue}");
                        result = nodeValue;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Проверенное значение дерева {nodeValue.Value}");

                        if (nodeTree.Left != null)
                        {
                            stack.Push(nodeValue.Left);
                        }
                        if (nodeTree.Right != null)
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
