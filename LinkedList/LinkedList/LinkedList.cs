﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {

        internal Node head; //new


        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);

        }
        internal void AddAppend(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the Append linked list", node.data);
        }
        public Node InsertMiddle(int data, int position)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid position");
            else
            {
                Node temp = this.head;
                while (position-- != 0)
                {

                    if (position == 1)
                    {
                        node.next = head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine("{0} inserted into the Middle of linked list", node.data);
            return head;
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
            Console.WriteLine("\n");
        }

    }
}


