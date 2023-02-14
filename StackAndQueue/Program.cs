using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the option below:");
            Console.WriteLine("\n1:operation related to stack\n2:operation related to queue");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option) {
                case 1:
                    CustomStackLinkedList stackLinkedList = new CustomStackLinkedList();
                    stackLinkedList.Push(70);
                    stackLinkedList.Push(30);
                    stackLinkedList.Push(56);
                    stackLinkedList.Peek();
                    stackLinkedList.Pop();
                    stackLinkedList.IsEmpty();
                    stackLinkedList.Display();
                    break;
                case 2:
                    CustomQueueLinkedList queueLinkedList = new CustomQueueLinkedList();
                    queueLinkedList.Enqueue(56);
                    queueLinkedList.Enqueue(30);
                    queueLinkedList.Enqueue(70);
                    Console.WriteLine("After performing Dequeue operation");
                    queueLinkedList.Dequeue();
                    //queueLinkedList.Dequeue();
                    //queueLinkedList.Dequeue();
                    queueLinkedList.Display();
                    break;
           
        }
            Console.ReadLine();
        }
    }
}
