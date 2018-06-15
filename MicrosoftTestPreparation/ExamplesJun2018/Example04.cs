using System;
using System.Collections.Generic;
using System.Text;
using MicrosoftTestPreparation.March2018;

namespace MicrosoftTestPreparation.ExamplesJun2018
{
    //Single linked lists contain nodes which have a data field as well as a 'next' field, which points to the next node in list of nodes.
    //Node is defined as

    //struct Node
    //{
    //    char data;
    //    Node* next;
    //};

    //Last node in list has next pointer equal to NULL.

    //Write a function

    //void reverseNodes(Node** head, int indexA, int indexB)


    //which should reverse order of nodes in list, starting from node on position indexA until node on position indexB.

    //Head node is on position 1.

    //Examples:
    //Input Output
    //‘a’ -> ‘c’ -> ‘x’ -> ‘q’ -> ‘e’ -> ‘2’ 
    //indexA = 2 
    //indexB = 4	‘a’ -> ‘q’ -> ‘x’ -> ‘c’ -> ‘e’ -> ‘2’

    class Example04
    {
        public void ReverseNodes(Node head, int indexA, int indexB)
        {
            var current = head;
            //TODO check index

            int length = (indexB - indexA) + 1;
            Console.WriteLine("Length: " + length + "\n");
            Node[] range = new Node[length];

            int counter = 0;
            int k = 0;
            Node indexAPreNode = null;
            Node indexBPostNode = null;

            while (current.next != null)
            {
                counter++;
                if (counter == (indexA - 1))
                    indexAPreNode = current;
                if (counter == indexB)
                    indexBPostNode = current.next;

                if (counter >= indexA && counter <= indexB)
                {
                    range[k] = current;
                    k++;
                }               
                current = current.next;
            }

            //Console.WriteLine("****************************** \n\n ");
            for (int i = range.Length - 1; i > 0; i--)
            {
                //Console.WriteLine("+++ " + range[i].data);
                range[i].next = range[(i - 1)];
            }

            if (indexAPreNode != null)
            {
                indexAPreNode.next = range[range.Length - 1];
            }

            if (indexBPostNode != null)
            {
                range[0].next = indexBPostNode;
            }
        }

    }
}
