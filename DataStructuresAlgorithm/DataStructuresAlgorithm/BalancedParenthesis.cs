using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.Utility
{
    class BalancedParenthesis
    {
        static string Balfilepath = @"C:\Users\admin\Desktop\github\DataStructuresAlgo\DataStructuresAlgorithm\DataStructuresAlgorithm\Utility\parenthisis.txt";
        StackOperation<string> stack = new StackOperation<string>();
        public void CheckParanthsis()
        {
            string text = File.ReadAllText(Balfilepath);
            string[] parArr = text.Split(" ");
            foreach (var item in parArr)
            {
                if (item == "(")
                {
                    stack.Push("(");
                }
                if (item == ")")
                {
                    stack.Pop(")");
                }
            }
            if (stack.IsEmpty())
            {
                Console.WriteLine("This is balanced paranthesis");
            }
            else
            {
                Console.WriteLine("This is not balanced paranthesis");
            }
        }
    }
}
