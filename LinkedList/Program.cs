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
            //Welcome Message
            Console.WriteLine("=-=-=-=-=-Welcome To The Linked List Program-=-=-=-=-=");

            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(70);

            //Display Data Before Adding into  Linked List
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Display Data Before Adding into  Linked List ::");
            Console.WriteLine("-----------------------------------------------");
            linkedList.Display();

            //Adding Data Between 2 Data
            linkedList.InsertAtParticularPosition(2, 30);

            //Display Data After Adding into  Linked List
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Display Data Before Adding into  Linked List ::");
            Console.WriteLine("-----------------------------------------------");

            linkedList.Display();

            Console.ReadLine();
        }
    }
}
