using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class CustomQueueLinkedList
    {
        public Node head;
        public void Enqueue(int data) 
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} inserted into queue", newNode.data);
        }
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Console.WriteLine("{0} removed from queue ", head.data);
            head = head.next;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine(" Queue is empty");
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
