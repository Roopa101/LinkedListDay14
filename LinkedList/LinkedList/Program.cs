using System;
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
            Console.WriteLine("Hello World!");
            LinkedList list1 = new LinkedList();
            list1.Add(56);
            list1.Add(30);
            list1.Add(70);
            list1.Display();
            LinkedList list2 = new LinkedList();
            //Appends the Nodes
            list2.AddAppend(56);
            list2.AddAppend(30);
            list2.AddAppend(70);
            list2.Display();
            Console.ReadKey();
        }
    }
}
