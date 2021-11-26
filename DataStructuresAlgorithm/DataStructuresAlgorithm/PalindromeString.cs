using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.Utility
{
    class PalindromeString
    {
        public void checkPalindrome(string str)
        {
            QueueOperation<char> queue = new QueueOperation<char>();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                queue.Enqueue(str[i]);
            }
            string rev = "";
            while (!queue.IsEmpty())
            {
                rev = rev + queue.DeQueue();
            }
            if (str.Equals(rev))
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}
