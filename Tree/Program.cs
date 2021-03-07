using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Asks the user how many nodes to create and randomly populate.
             * Also asks what the maximum allowed node value is.
             * Clears the console after answer.
             */
            Console.WriteLine("How many nodes do you want to create and randomly populate? ");
            Console.Write("Input: ");
            string inputStringNodes = Console.ReadLine();

            Console.WriteLine("What is the maximum value allowed in the nodes? ");
            Console.Write("Input: ");
            string inputStringValue = Console.ReadLine();

            Console.Clear();

            // Converts the inputs to integers
            int inputIntNode = Convert.ToInt32(inputStringNodes);
            int inputIntValue = Convert.ToInt32(inputStringValue);

            // Entry node to the tree
            Node parent = null;

            // Random for populating the tree
            Random rnd = new Random();

            Console.WriteLine("Creating and populating " + inputStringNodes + " nodes with a maximum node value of " + inputIntValue + ":");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");

            // For loop that populates the nodes
            for (int i = 0; i < inputIntNode; i++)
            {
                int randomInt = rnd.Next(0, inputIntValue);

                Node newNode = new Node(randomInt);

                // If the parent node has nothing in it, sets "newNode" as the root of the tree
                if (parent == null)
                {
                    Console.WriteLine(newNode.value + " is now the Root");
                    parent = newNode;
                }

                else
                {
                    newNode.AddNode(parent);
                }
            }
        }
    }
}
