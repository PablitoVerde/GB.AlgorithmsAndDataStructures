using System;
using System.Collections.Generic;
using System.Text;

/*Реализуйте методы поиска в дереве "поиск в ширину" и "поиск в глубину" 
 * (класс дерева должен быть реализован в ДЗ урока 4) с выводом каждого шага в консоль. 
 */

namespace GB.AlgorithmsAndDataStructures.Lesson5
{
    class Task1 : ILesson
    {
        public string Name => "Task5.1";

        public string Description => "Поиск по дереву в глубину и в ширину";

        public void Demo()
        {
            //Создание дерева
            NodeWithSearch<int> nodeTree = new NodeWithSearch<int> { Value = 10 };
            nodeTree.AddItem(10);
            nodeTree.AddItem(1);
            nodeTree.AddItem(100);
            nodeTree.AddItem(4);
            nodeTree.AddItem(50);
            nodeTree.AddItem(0);
            nodeTree.AddItem(19);
            nodeTree.AddItem(45);
            nodeTree.AddItem(17);
            nodeTree.AddItem(44);
            nodeTree.AddItem(46);
            nodeTree.AddItem(38);
            nodeTree.AddItem(55);
            nodeTree.AddItem(7);
            nodeTree.AddItem(9);
            nodeTree.AddItem(15);
            nodeTree.AddItem(25);

            //Очистка консоли, вывод дерева на экран
            Console.Clear();
            nodeTree.PrintTree();

            //создание пустой строки для пользовательского интерфейса
            Console.WriteLine();

            //Поиск узла дерева по значению в ширину, получение узла, вывод значения узла на экран.
            //Для проверки работоспособности метода выводятся все пройденные значения по порядку
            Console.WriteLine("Поиск в ширину");
            Lesson4.Node<int> searchedValueBFS = NodeWithSearch<int>.searchBFS(nodeTree, 45);
            Console.WriteLine($"Значение полученного узла дерева - {searchedValueBFS.Value}");

            //Поиск узла дерева по значению в глубину, получение узла, вывод значения узла на экран.
            //Для проверки работоспособности метода выводятся все пройденные значения по порядку
            Console.WriteLine("Поиск в глубину");
            Lesson4.Node<int> searchedValueDFS = NodeWithSearch<int>.searchDFS(nodeTree, 45);
            Console.WriteLine($"Значение полученного узла дерева - {searchedValueDFS.Value}");

            Console.ReadKey();
        }
    }
}
