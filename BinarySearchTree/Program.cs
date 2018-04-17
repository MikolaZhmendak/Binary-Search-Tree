using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree myTree = new BinaryTree();
            myTree.addItem(50);
            myTree.addItem(60);
            myTree.addItem(15);
            myTree.addItem(45);
            myTree.addItem(86);
            myTree.addItem(65);
            myTree.searchItem(45);
            Console.ReadLine();
        }
    }
}
