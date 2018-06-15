using System;
using MicrosoftTestPreparation.ExamplesJun2018;
using MicrosoftTestPreparation.March2018;
using MicrosoftTestPreparation.Novembar2017;

namespace MicrosoftTestPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*********************** March2018 First *****************************\n");
            var singlyLikedList = new SinglyLinkedList();
            Random rnd = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                singlyLikedList.AddLast(rnd.Next(1,211));
            }

            singlyLikedList.PrintAllNodes();

            var current = singlyLikedList.Head;

            var divisibleThree = new SinglyLinkedList();
            var evenNumbers = new SinglyLinkedList();
            var oddNumbers = new SinglyLinkedList();

            while (current != null)
            {
                if (current.data % 3 == 0)
                {
                    divisibleThree.AddLast(current.data);    
                }
                else if (current.data % 2 == 0)
                {
                    evenNumbers.AddLast(current.data);
                }
                else
                {
                    oddNumbers.AddLast(current.data);
                }

                current = current.next;
            }

            Console.WriteLine("\ndivisibleThree before: ");
            divisibleThree.PrintAllNodes();

            Console.WriteLine("\nevenNumbers before: ");
            evenNumbers.PrintAllNodes();

            Console.WriteLine("\noddNumbers before: ");
            oddNumbers.PrintAllNodes();

            //var orderedList = new SinglyLinkedList();
            divisibleThree.Last.next = evenNumbers.First;
            divisibleThree.Last.next = oddNumbers.First;

            Console.WriteLine("\ndivisibleThree after: ");
            divisibleThree.PrintAllNodes();
            
            Console.WriteLine("\n*********************** ExamplesJun2018 Example01 *****************************\n");
            Example01 ex = new Example01();            
            if (ex.IsIsomorphic2("brain", "space"))
                Console.WriteLine("IsIsomorphic");
            else
                Console.WriteLine("IsNotIsomorphic");

            Console.WriteLine("\n*********************** ExamplesJun2018 Example04 *****************************\n");

            var inputLikedList = new SinglyLinkedList();
            for (int i = 0; i < 10; i++)
            {
                inputLikedList.AddLast(rnd.Next(1, 211));
            }

            Console.WriteLine("Input list before changes: \n");
            inputLikedList.PrintAllNodes();
            Example04 ex04 = new Example04();
            ex04.ReverseNodes(inputLikedList.Head, 2, 4);
            Console.WriteLine("Input list after changes: \n");
            inputLikedList.PrintAllNodes();

            Console.WriteLine("\n*********************** November2017 Second *****************************\n");
            Novembar2017_Second sec = new Novembar2017_Second();

            if (sec.AreAnagram("A@A@", "BAAC"))
                Console.WriteLine("Strings are anagram!");
            else
                Console.WriteLine("Strings arn't anagram!");

            Console.WriteLine("Press escape for exit!");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
