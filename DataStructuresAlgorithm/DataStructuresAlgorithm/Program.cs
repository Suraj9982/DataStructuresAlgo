using System;
using DataStructuresAlgorithm.Utility;

namespace DataStructuresAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION :\n 1.Unordered List\n2.OrderList\n3.Balanced Paranthesis\n4.PalindromeString\n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UnOrderedList unorder = new UnOrderedList();
                        unorder.ListManage();
                        break;
                    case 2:
                        OredredList order = new OredredList();
                        order.NumberManage();
                        break;
                    case 3:
                        BalancedParenthesis balance = new BalancedParenthesis();
                        balance.CheckParanthsis();
                        break;
                    case 4:
                        PalindromeString check = new PalindromeString();
                        Console.WriteLine("enter the string");
                        string str = Console.ReadLine();
                        check.checkPalindrome(str);
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 5");
                        break;
                }
            }
        }
    }
}
