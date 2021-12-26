using System;
using System.Collections.Generic;
using System.Text;

namespace GB.AlgorithmsAndDataStructures.Lesson4
{
    //Интерфейс реализации бинарного дерева поиска
    public interface ITree<T>
    {
        Node<T> GetRoot();
        void AddItem(T value); // добавить узел
        void RemoveItem(T value); // удалить узел по значению
        Node<T> GetNodeByValue(T value); //получитьузел дерева по значению
        void PrintTree(); //вывести дерево в консоль       
    }

}
