using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public   Node rightNode;
        public   Node leftNode;
        public int data;      


        public Node()
        {

        }
        public Node(int data)
        {
            this.data = data;
        }
    }
}
