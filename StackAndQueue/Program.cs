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
            CustomStackLinkedList stackLinkedList = new CustomStackLinkedList();
            stackLinkedList.Push(70);
            stackLinkedList.Push(30);
            stackLinkedList.Push(56);
            stackLinkedList.Peek();
            stackLinkedList.Pop();
            stackLinkedList.IsEmpty();
            stackLinkedList.Dispaly();           
            Console.ReadLine();
        }
    }
}
