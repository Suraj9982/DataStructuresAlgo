using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.Utility
{
    class CashCounter
    {
        public void ManagePeople()
        {
            QueueOperation<string> queue = new QueueOperation<string>();
            Console.WriteLine("enter the number of people in queue");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[num];
            int[] bal = new int[num];
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("enter the name");
                name[i] = Console.ReadLine();
                queue.Enqueue(name[i]);
                Console.WriteLine("enter the bankbalance of {0}", name[i]);
                bal[i]= Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("CHOOSE OPTION:\n1.Withdrawl\n2.Deposit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) 
                {
                    case 1:
                        Console.WriteLine("enter the amount to be withdraw");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        if(amount>20000)
                        {
                            Console.WriteLine("the limit of withdraw of one day is 20000");
                            Console.WriteLine("----Sorry For Inconveinece----");
                        }
                        else
                        {
                            bal[i] -= amount;
                            Console.WriteLine("The current balance of {0} is {1}", name[i], bal[i]);
                            queue.DeQueue(); 
                        }
                        break;
                    case 2:
                        Console.WriteLine("enter the amount to deposit");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        if (deposit < 1000)
                        {
                            Console.WriteLine("your amount should be greater than 1000 for deposit");
                            Console.WriteLine("----Sorry For Inconveinece----");
                        }
                        else
                        {
                            bal[i] += deposit;
                            Console.WriteLine("The current balance of {0} is {1}", name[i], bal[i]);
                            queue.DeQueue();  
                        }
                        break;
                    default:
                        Console.WriteLine("Please choose only Withdraw or Deposit");
                        break;
                }
            }
            if (queue.IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
                Console.WriteLine("Queue is not empty");
        }
    }
}
