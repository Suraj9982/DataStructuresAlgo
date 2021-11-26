using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.Utility
{
    public class LinkedList<T> 
    {
        internal Node<T> head;
        public void Adddata(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted items in linkedlist", node.data);
        }
        internal void AddInReverseOrder(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newnode;
                head.next = temp;
            }
        }
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node<T> InsertAtPostion(int postion, T data)
        {
            Node<T> Newestnode = new Node<T>(data);
            if (this.head == null)
            {
                return Newestnode;
            }
            if (postion == 0)
            {
                Newestnode.next = this.head;
                this.head = Newestnode;
                return this.head;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while (current != null && count < postion)
            {
                prev = current;
                current = current.next;
                count++;
            }
            Newestnode.next = prev.next;
            prev.next = Newestnode;
            return this.head;
        }
        internal Node<T> RemoveFirstnode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node<T> RemovelastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node<T> newnode = head;
            while (newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            newnode.next = null;
            return null;
        }
        internal bool Search(T value)
        {
            Node<T> node = this.head;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    Console.WriteLine("Data found: {0}",value);
                    return true;
                }
                node = node.next;
            }
            return false;
        }
        public void Delete(T data)
        {
            Node<T> temp = this.head;
            while (temp.next != null)
            {
                if (temp.next.data.Equals(data))
                {
                    Console.WriteLine("data is deleted {0}", temp.next.data);
                    temp.next = temp.next.next;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }
        public string ReturnString()
        {
            string text = "";
            Node<T> current = this.head;
            if (this.head != null)
            {
                text += current.data;
                current = current.next;
                while (current != null)
                {
                    text = text + "," + current.data;
                    current = current.next;
                }
                return text;
            }
            else
            {
                Console.WriteLine("list is empty");
                return default;
            } 
        }
        public string WriteInFile()
        {
            Node<T> temp = this.head;
            string s = " ";
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                s = s + temp.data;

                temp = temp.next;
            }
            return s;
        }
    }
}
