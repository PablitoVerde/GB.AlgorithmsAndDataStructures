using System;
using System.Collections.Generic;
using System.Text;

/*
Реализуйте класс двоичного дерева поиска с операциями вставки, удаления, поиска. 
Также напишите метод вывода в консоль дерева, 
чтобы увидеть, насколько корректно работает ваша реализация.
*/

namespace GB.AlgorithmsAndDataStructures.Lesson4
{
    class Task1 : ILesson
    {
        string ILesson.Name => "Task4.1";

        string ILesson.Description => "Реализация двоичного дерева поиска";

       void ILesson.Demo()
        {
            Console.Clear();
            Console.WriteLine("Дерево из одного элемента");
            Node<int> nodeTree = new Node<int> { Value = 8 };
            nodeTree.PrintTree();
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Добавлены в дерево новые узлы");

            nodeTree.AddItem(4);
            nodeTree.AddItem(15);
            nodeTree.AddItem(13);
            nodeTree.AddItem(18);
            nodeTree.AddItem(20);

            nodeTree.PrintTree();
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Добавлены в дерево новые узлы");

            nodeTree.AddItem(10);
            nodeTree.AddItem(5);
            nodeTree.AddItem(2);
            nodeTree.AddItem(3);
            nodeTree.AddItem(7);

            nodeTree.PrintTree();
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Вывод в консоль значения элемента со значением 10. Осуществляется поиск элемента по значению, потом оно же и выводится для перепроверки алгоритма");
            Console.WriteLine(nodeTree.GetNodeByValue(10).Value);
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Удаление двух узлов из дерева.");

            nodeTree.RemoveItem(13);
            nodeTree.RemoveItem(3);

            nodeTree.PrintTree();

            Console.ReadKey();
        }

        public void GetTree()
        {
            
        }
    }
}
