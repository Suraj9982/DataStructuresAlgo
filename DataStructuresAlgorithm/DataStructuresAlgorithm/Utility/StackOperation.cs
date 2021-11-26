using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.Utility
{
    class StackOperation<T>
    {
        Node<T> top;
        public StackOperation()
        {
            this.top = null;
        }
        public T Push(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (top == null)
            {
                newnode.next = null;
            }
            else
            {
                newnode.next = top;
            }
            top = newnode;
            Console.WriteLine("{0} item pushed to stack ", newnode.data);
            return data;
        }
        internal void Pop(T data)
        {
            if (top == null)
            {
                Console.WriteLine("stack is in undefllow condition");
                return;
            }
            Console.WriteLine("{0} item pooped out from stack", top.data);
            top = top.next;
        }
        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("stack is in undefllow condition");
                return;
            }
            Console.WriteLine("{0},is on the top of the stack", this.top.data);
        }
        internal void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal bool IsEmpty()
        {
            Node<T> temp = this.top;
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return true;
            }
            return false;
        }
    }
}
