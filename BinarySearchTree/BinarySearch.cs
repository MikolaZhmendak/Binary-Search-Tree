using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearch
    {
        Node root;
        Node item;
        int next;
        int moveRight;
        int moveLeft;
        public BinarySearch(int next, int moveLeft, int moveRight)
        {
            this.next = next;
            this.moveRight = moveRight;
            this.moveLeft = moveLeft;
        }

        public void addItem(int data)
        {
            root = new Node();
            if (root == null)
            {
                root = item;
                return;
            }

            }

        }
        public void searchItem(int data)
        {

        }
    }



