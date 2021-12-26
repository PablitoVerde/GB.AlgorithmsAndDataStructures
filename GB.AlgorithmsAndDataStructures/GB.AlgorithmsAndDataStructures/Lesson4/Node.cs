using System;
using System.Collections.Generic;
using System.Text;

namespace GB.AlgorithmsAndDataStructures.Lesson4
{
    //Реализация двоичного дерева поиска с операциями вставки, удаления, поиска. 
    public class Node<T> : ITree<T>
    {
        //Само значение узла
        public T Value { get; set; }

        //Узел слева
        public Node<T> Left { get; set; }

        //Узел справа
        public Node<T> Right { get; set; }

        //Узел-родитель
        public Node<T> Parent { get; set; }

        public override bool Equals(object obj)
        {
            Node<T> node = obj as Node<T>;
            if (node == null)
                return false;
            return EqualityComparer<T>.Default.Equals(Value, node.Value);
        }

        /// <summary>
        /// Получить корневой узел
        /// </summary>
        /// <returns></returns>
        public Node<T> GetRoot()
        {
            Node<T> rootNode = new Node<T>();

            //Если экземпляр класса не имеет родителя, значит он - корневой узел
            if (this.Parent == null)
                rootNode = this;

            //В противном случае рекурсивно идет по родительским узлам
            else
            {
                rootNode = this.Parent;
                rootNode.GetRoot();
            }

            return rootNode;
        }

        /// <summary>
        /// Добавление узла дерева. Значение должно быть int.
        /// </summary>
        /// <param Значение="value"></param>
        public void AddItem(T value)
        {
            if (this.Value == null)
            {
                this.Value = value;
            }
            else if (Convert.ToInt32(value) < Convert.ToInt32(this.Value))
            {
                if (this.Left == null)
                {
                    Node<T> newNode = new Node<T> { Value = value, Parent = this, Left = null, Right = null };
                    this.Left = newNode;
                }
                else
                {
                    this.Left.AddItem(value);
                }
            }
            else if (Convert.ToInt32(value) > Convert.ToInt32(this.Value))
            {
                if (this.Right == null)
                {
                    Node<T> newNode = new Node<T> { Value = value, Parent = this, Left = null, Right = null };
                    this.Right = newNode;
                }
                else
                {
                    this.Right.AddItem(value);
                }
            }
        }

        /// <summary>
        /// Удаление узла по значению. Если у узла есть узлы ниже
        /// </summary>
        /// <param Значение="value"></param>
        public void RemoveItem(T value)
        {
            Node<T> tempNode = GetNodeByValue(value);

            if (tempNode.Left == null && tempNode.Right == null)
            {
                if (tempNode == tempNode.Parent.Left)
                    tempNode.Parent.Left = null;
                else
                    tempNode.Parent.Right = null;
            }
            else
            {
                if (tempNode.Parent.Left == tempNode)
                {
                    tempNode.Parent.Left = tempNode.Left;
                }

                if (tempNode.Parent.Right == tempNode)
                {
                    tempNode.Parent.Right = tempNode.Right;
                }

            }
        }

        /// <summary>
        /// Получить узел по значению. Значение должно иметь формат int. 
        /// </summary>
        /// <param Значение узла="value"></param>
        /// <returns></returns>
        public Node<T> GetNodeByValue(T value)
        {
            Node<T> resultNode = new Node<T>();

            if (Convert.ToInt32(value) == Convert.ToInt32(this.Value))
            {
                resultNode = this;
            }
            else if (Convert.ToInt32(value) < Convert.ToInt32(this.Value))
            {
                Node<T> tempNode = this.Left;
                resultNode = tempNode.GetNodeByValue(value);
            }
            else if (Convert.ToInt32(value) > Convert.ToInt32(this.Value))
            {
                Node<T> tempNode = this.Right;
                resultNode = tempNode.GetNodeByValue(value);
            }

            return resultNode;
        }


        /// <summary>
        /// Метод по выводу в консоль дерева.
        /// </summary>
        /// <param Узел дерева="node"></param>
        /// <param Координата Х="x"></param>
        /// <param Координата У="y"></param>
        /// <returns></returns>
        public int Print(Node<T> node, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(node.Value);

            var loc = y;

            if (node.Right != null)
            {
                Console.SetCursorPosition(x + 2, y);
                Console.Write("--");
                y = Print(node.Right, x + 4, y);
            }

            if (node.Left != null)
            {
                while (loc <= y)
                {
                    Console.SetCursorPosition(x, loc + 1);
                    Console.Write(" |");
                    loc++;
                }
                y = Print(node.Left, x, y + 2);
            }

            return y;
        }

        public void PrintTree()
        {
            Print(this, 3, 3);
        }
    }
}