﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program");
            LinkedList list = new LinkedList();
            list.AddAppend(56);
            list.AddAppend(70);
            list.InsertMiddle(30, 2);
            list.Display();
            Console.ReadKey();
        }
    }
}