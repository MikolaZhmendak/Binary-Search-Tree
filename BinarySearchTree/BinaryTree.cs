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
           
        
        public bool Search( int value)
        {
            currentNode = headNode;
            while (currentNode.leftNode != null || currentNode.rightNode != null)
            {
                if (currentNode.data == value)
                {
                    Console.WriteLine("You are searching for the following node: " + value);
                    Console.WriteLine("Value we found: " + currentNode.data);
                    Console.ReadLine();
                    return true;
                }

                else if (value < currentNode.data)
                {
                    Console.WriteLine("Value found: " + currentNode.data);
                    Console.WriteLine(value + "Is less then " + currentNode.data);
                    Console.WriteLine("We now move to the Left of the binary tree");
                    currentNode = currentNode.leftNode;
                   
                }

                else
                {
                    Console.WriteLine("The value we found:" + currentNode.data);
                    Console.WriteLine(value + "Is greated then " + currentNode.data);
                    Console.WriteLine("We now move to the Right of the binary tree");
                    
                }
            }
                if (currentNode.data == value)
                {
                    Console.WriteLine("You are searching for: " + value);
                    Console.WriteLine("We foound: " + currentNode.data);
                    Console.ReadLine();
                    return true;
                }
                else
                {
                    Console.WriteLine("Value was not found");
                    return false;
                }
            }
    
        }
    }




