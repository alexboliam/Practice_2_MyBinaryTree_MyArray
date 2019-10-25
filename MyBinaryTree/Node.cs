using System;
using System.Collections.Generic;
using System.Text;

namespace MyBinaryTree
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node() { }
        public Node(T Data)
        {
            this.Data = Data;
        }

        
    }
}
