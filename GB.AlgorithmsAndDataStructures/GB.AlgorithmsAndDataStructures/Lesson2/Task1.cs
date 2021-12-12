using System;
using System.Collections.Generic;
using System.Text;

namespace GB.AlgorithmsAndDataStructures.Lesson2
{
    class Task1 : ILesson
    {        
        public string Name => "Task2.1";

        public string Description => "Реализация двусвязного списка";

        public void Demo()
        {
            // Инициализация базового списка из 5 элементов (1 статичный из класса)
            Random rnd = new Random();

            Node.startingNode.AddNode(rnd.Next(0, 100));
            Node.startingNode.AddNode(rnd.Next(0, 100));
            Node.startingNode.AddNode(rnd.Next(0, 100));
            Node.startingNode.AddNode(101);
            Node.startingNode.AddNode(rnd.Next(0, 100));

            Console.WriteLine("---------");
            Console.WriteLine($"Количество элементов в связанном списке - {Node.startingNode.GetCount()}");
            Console.WriteLine("---------");

            Console.WriteLine("Добавление нового элемента в конец списка");
            Node.startingNode.AddNode(105);
            PrintNodes(Node.startingNode);
            Console.WriteLine("---------");

            Console.WriteLine("Добавление нового элемента после указанного");
            Node.startingNode.AddNodeAfter(Node.startingNode.FindNode(101), 155);
            PrintNodes(Node.startingNode);
            Console.WriteLine("---------");

            Console.WriteLine("Удаление элемента списка по номеру");
            Node.startingNode.RemoveNode(4);
            PrintNodes(Node.startingNode);
            Console.WriteLine("---------");

            Console.WriteLine("Удаление элемента из списка");
            Node.startingNode.RemoveNode(Node.startingNode.FindNode(155));
            PrintNodes(Node.startingNode);
            Console.WriteLine("---------");

            Console.WriteLine("Поиск ноды по значению");
            Node.startingNode.AddNode(177);
            Node.startingNode.AddNode(180);
            Node.startingNode.AddNode(191);
            PrintNodes(Node.startingNode);
            Console.WriteLine("---------");

            Node searchedNode = Node.startingNode.FindNode(180);
            PrintOneNode(searchedNode);

            Console.ReadKey();
        }


        /// <summary>
        /// Вывод на экран элементов списка.
        /// </summary>
        /// <param Первый элемент списка="node"></param>
        public static void PrintNodes(Node node)
        {
            while (node != null)
            {
                PrintOneNode(node);
                node = node.NextNode;
            }

        }

        /// <summary>
        /// Метод вывода на экран отдельного элемента списка.
        /// </summary>
        /// <param Элемент списка="node"></param>
        public static void PrintOneNode(Node node)
        {
            //Цвет для наглядности вывода
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Текущее значение - {node.Value}. ");
            Console.ResetColor();

            if (node.PrevNode != null)
            {
                Console.Write($"Предыдущий элемент - {node.PrevNode.Value}. ");
            }
            else
            {
                Console.Write("Предыдущего элемента не существует. ");
            }
            if (node.NextNode != null)
            {
                Console.Write($"Следующий элемент - {node.NextNode.Value}. ");
            }
            else
            {
                Console.Write("Следующего элемента не существует. ");
            }
            Console.WriteLine();
        }
    }
}
