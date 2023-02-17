using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CreatedAlgos
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
            }
        }

        public static void DeleteBackHalf()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current +"->");
                current = current.next;
            }
        } 
        public static void CustomLinkedList()
        {
            CreatedAlgos ll = new CreatedAlgos();

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            ll.head = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
        }
    }
}
