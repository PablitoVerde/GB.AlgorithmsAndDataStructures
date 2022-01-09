using System;
using System.Collections.Generic;
using System.Text;

namespace GB.AlgorithmsAndDataStructures.Lesson2
{

    // Класс двусвязного списка
    class Node : ILinkedList
    {
        static public Node startingNode = new Node(0, null, null);

        // значение
        public int Value { get; set; }

        //Следующий элемент
        public Node NextNode { get; set; }

        //Предыдущий элемент
        public Node PrevNode { get; set; }

        /// <summary>
        /// Базовый конструктор для звена списка (звено не связано с текущим списком).
        /// </summary>
        public Node(int value)
        {
            this.Value = value;
            this.PrevNode = null;
            this.NextNode = null;
        }

        /// <summary>
        /// Метод инициализации первой ноды
        /// </summary>
        /// <param name="value"></param>
        /// <param name="nextNode"></param>
        public Node(int value, Node nextNode, Node prevNode)
        {
            this.Value = value;
            this.PrevNode = prevNode;
            this.NextNode = nextNode;
        }

        /// <summary>
        /// Метод по подсчету элементов списка
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            int result = 0;

            Node tempNode = this;

            while (tempNode != null)
            {
                result++;
                tempNode = tempNode.NextNode;
            }
            return result;
        }

        /// <summary>
        /// Метод по добавлению нового элемента в конец списка
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            Node newNode = new Node(value);

            //Создание временного клона, т.е. this - только для чтения. Переназначение не получится
            Node tempNode = this;

            while (tempNode.NextNode != null)
            {
                tempNode = tempNode.NextNode;
            }

            tempNode.NextNode = newNode;
            newNode.PrevNode = tempNode;
        }

        /// <summary>
        /// Метод по добавлению нового элемента после указанного узла
        /// </summary>
        /// <param После указанного узла будет вставлен элемент="node"></param>
        /// <param Значение нового элемента="value"></param>
        public void AddNodeAfter(Node node, int value)
        {
            Node newNode = new Node(value);
            Node tempNode = this;

            while (tempNode != null)
            {
                if (tempNode == node)
                {
                    if (tempNode.NextNode == null)
                    {
                        tempNode.NextNode = newNode;
                        newNode.PrevNode = tempNode;
                    }
                    else
                    {
                        tempNode.NextNode.PrevNode = newNode;
                        newNode.NextNode = tempNode.NextNode;
                        tempNode.NextNode = newNode;
                        newNode.PrevNode = tempNode;
                    }
                    break;
                }
                tempNode = tempNode.NextNode;
            }
        }

        /// <summary>
        /// Удаление элемента по индексу
        /// </summary>
        /// <param Индекс элемента="index"></param>
        public void RemoveNode(int index)
        {
            int count = this.GetCount();

            Node tempNode = this;

            if (index <= count && index > 0)
            {
                int i = 0;

                while (tempNode != null)
                {
                    i++;
                    if (i == index)
                    {
                        tempNode.NextNode.PrevNode = tempNode.PrevNode;
                        tempNode.PrevNode.NextNode = tempNode.NextNode;
                        break;
                    }
                    tempNode = tempNode.NextNode;
                }
            }
        }

        /// <summary>
        /// Метод по удалению из списка элемента
        /// </summary>
        /// <param Нода="node"></param>
        public void RemoveNode(Node node)
        {
            Node tempNode = this;

            while (tempNode != null)
            {
                if (tempNode == node)
                {
                    //обработка на предмет последнего элемента в списке
                    if (tempNode.NextNode == null)
                    {
                        tempNode.PrevNode.NextNode = null;
                    }
                    // обработка на предмет первого элемента в списке
                    else if (tempNode.PrevNode == null)
                    {
                        tempNode.NextNode.PrevNode = null;
                    }
                    else
                    {
                        tempNode.NextNode.PrevNode = tempNode.PrevNode;
                        tempNode.PrevNode.NextNode = tempNode.NextNode;
                    }
                    break;
                }
                tempNode = tempNode.NextNode;
            }
        }

        /// <summary>
        /// Метод по поиску конкретного элемента из списка по значению. В случае отсутствия вернет первую ноду
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public Node FindNode(int searchValue)
        {
            Node result = this;

            Node tempNode = this;

            while (tempNode != null)
            {
                if (tempNode.Value == searchValue)
                {
                    result = tempNode;
                    break;
                }
                tempNode = tempNode.NextNode;
            }

            return result;
        }
    }
}
