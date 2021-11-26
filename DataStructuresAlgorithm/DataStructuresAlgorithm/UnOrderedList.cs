using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAlgorithm.Utility;

namespace DataStructuresAlgorithm.Utility
{
    class UnOrderedList
    {
      LinkedList<string> linkedList = new LinkedList<string>(); 
        static string WordFilepath= @"C:\Users\admin\Desktop\github\DataStructuresAlgo\DataStructuresAlgorithm\DataStructuresAlgorithm\Utility\word.txt";
        public void ListManage()
        {
            string data = File.ReadAllText(WordFilepath);
            string[] words = data.Split(" ");
            foreach (var result in words)
            {
                linkedList.Adddata(result);

            }
            Console.WriteLine("enter the word you want to search for");
            string word = Console.ReadLine();
            if (linkedList.Search(word))
            {
                linkedList.Delete(word);
            }
            else
            {
                linkedList.Adddata(word);
            }
            linkedList.Display();
            string text = linkedList.WriteInFile();
            File.WriteAllText(WordFilepath , text);
        }
    }
}
