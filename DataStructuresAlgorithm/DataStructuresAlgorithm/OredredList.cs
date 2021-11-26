using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.Utility
{
    class OredredList
    {
        LinkedList<string> linked = new LinkedList<string>();
        static string Numfilepath = @"C:\Users\admin\Desktop\github\DataStructuresAlgo\DataStructuresAlgorithm\DataStructuresAlgorithm\Utility\numbers.txt";
        public void NumberManage()
        {
            string num = File.ReadAllText(Numfilepath);
            string[] numbers = num.Split(" ");
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                linked.Adddata(item);
            }
            Console.WriteLine("enter the number you want to search for");
            string number = Console.ReadLine();
            if (linked.Search(number))
            {
                linked.Delete(number);
            }
            else
            {
                linked.Adddata(number);
            }
            linked.Display();
            string textnum = linked.WriteInFile();
            File.WriteAllText(Numfilepath, textnum);
        }
    }
}
