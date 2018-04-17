using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        
      Node headNode;
      Node currentNode;
        
        public BinaryTree()
        {
           
            
        }
        public BinaryTree(int data)
        {
            headNode = new Node(data);
        }

        public void addItem(int data)
        {
            Node addingToNode = new Node(data);
            if(headNode == null)
            {
                headNode = addingToNode;
                return;
            }

            currentNode = headNode;
            currentNode = Traverse(currentNode, addingToNode);

            if (currentNode.data > addingToNode.data)
            {
                currentNode.leftNode = addingToNode;
            }
            else
            {
                currentNode.rightNode = addingToNode;
            }
            
        }

         public Node Traverse(Node currentNode, Node addingToNode)
        {
            while (currentNode != null)
            {
                if (currentNode.data > addingToNode.data && currentNode.leftNode != null)
                {
                    currentNode = currentNode.leftNode;
                }
                else if (currentNode.data <= addingToNode.data && currentNode.rightNode != null)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    return currentNode;
                }
            }
            return currentNode;
        }
           
        
        public void searchItem (int value)
        {

        }
    }
}



