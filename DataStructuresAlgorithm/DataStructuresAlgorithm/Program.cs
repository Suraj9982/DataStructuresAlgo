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
                Console.WriteLine("CHOOSE OPTION : 1.Unordered List\n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UnOrderedList unorder = new UnOrderedList();
                        unorder.ListManage();
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 2");
                        break;
                }
            }
        }
    }
}
