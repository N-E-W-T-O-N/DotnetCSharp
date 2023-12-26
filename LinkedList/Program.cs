using System.Xml.Linq;
using static System.Random;
namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var l = new LL();
            l.Print();

            for (int i = 0; i < 10; i++)
            {
                l.Save(new Random().Next(5,100));
            }
            l.Print();
        }
    }

    class LL
    {
        public Node? head = null;

        public void  Save(int data)
        {
            if (head == null) 
            {
                head = new Node(data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = new Node(data);
            }
        }

        public void Print()
        {
            if (head == null) Console.WriteLine();
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data+" -> ");
                    temp = temp.next;
                }
                Console.Write("null");
            }
        }
    }

    class Node
    {
        public int data ;

        public Node? next =null;

        public Node(int data){  this.data = data; this.next = null; }
        
    }
}