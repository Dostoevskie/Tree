using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Node
    {
        // Initial fields for the class
        public int value;
        
        public Node left;
        public Node right;

        // Constructor
        public Node(int data)
        {
            value = data;

            left = null;
            right = null;
        }

        // AddNode method
        public void AddNode(Node parent)
        {
            // If parent node has nothing in it
            if (parent == null)
            {
                Console.WriteLine("Could not call 'AddNode' because parent was 'null'.");
                return;
            }

            // If the value of the parent node is the same as the value of the node being added
            else if (parent.value == this.value)
            {
                Console.WriteLine("Duplicate value, nothing has been added");
                return;
            }

            // If the value of the node being added is less than the value of the parent node
            else if (this.value < parent.value)
            {
                // Go left in the tree
                if (parent.left != null)
                {
                    // If there is already something in the left node, add a new node
                    AddNode(parent.left);
                }

                else
                {
                    // Left node is now set as the node being added
                    Console.WriteLine("Added " + this.value + " to the left of " + parent.value);
                    parent.left = this;
                }
            }


            else if (this.value > parent.value)
            {
                // Go right in the tree
                if (parent.right != null)
                {
                    // If there is already something in the right node, add a new node
                    AddNode(parent.right);
                }

                else
                {
                    // Right node is now set as the node being added
                    Console.WriteLine("Added " + this.value + " to the right of " + parent.value);
                    parent.right = this;
                }
            }

        }
    }
}
