using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class CustomStackLinkedList
    {
        public Node head;
        public void Push(int data) 
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = this.head;
            }
            head = newNode;
            Console.WriteLine("{0} pushed to the stack ", data);
        }
        public void Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} is the top of the stack list", head.data);
        }
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("value popped is {0}" ,head.data);
            head = head.next;
        }
        public void IsEmpty()
        {
            while (head != null)
            {
                Peek();
                Pop();
            }
        }
        public void Display() 
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Displaying nodes");
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
