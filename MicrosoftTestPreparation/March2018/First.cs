using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftTestPreparation.March2018
{
    //(eng) Is given singly-linked list of integers.
    //List should be sort on way as first numbers divisible with three then even numbers then odd numbers.
    //Order of numbers is not important. 
    //Do with the final number of additional variables.

    //(srb) Data je jednostruko ulancana lista celih brojeva.
    //Listu treba sortirati tako da prvo idu brojevi deljivi sa 3, pa parni pa neparni.
    //Poredak samih elemenata nije bitan. Uraditi uz konacan broj dodatnih promenljivih.

    public class Node
    {
        public Node next;
        public int data;
    }

    public class SinglyLinkedList
    {
        private Node _head;
        public Node Head => _head;

        public void PrintAllNodes()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public Node First { get { return _head;  } }
        public Node Last
        {
            get
            {
                Node curr = _head;
                if (curr == null)
                    return null;
                while (curr.next != null)
                    curr = curr.next;
                return curr;
            }
        }

        public void AddFirst(int data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = _head;

            _head = toAdd;
        }

        public void AddLast(int data)
        {
            if (_head == null)
            {
                _head = new Node();

                _head.data = data;
                _head.next = null;
            }
            else
            {                
                Node toAdd = new Node();
                toAdd.data = data;

                Last.next = toAdd;
            }
        }
    }
}
