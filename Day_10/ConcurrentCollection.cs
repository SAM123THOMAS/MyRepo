using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    internal class ConcurrentCollection
    {
        public static void Main2()
        {
            BlockingCollection<int> bc = new BlockingCollection<int>();
            bc.Add(1);  
            bc.Add(2);
            if (bc.TryAdd(3, TimeSpan.FromSeconds(1)))
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Failed to add");
            }

            Console.WriteLine("===============================================================");
            ConcurrentStack<int> stk= new ConcurrentStack<int>();
            stk.Push(111);
            stk.Push(2222);

            foreach (int i in stk)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("===============================================================");
            ConcurrentQueue<int> que= new ConcurrentQueue<int>();
            que.Enqueue(234);
            que.Enqueue(987);
            foreach(int i in que)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("===============================================================");

            ConcurrentBag<string> bag= new ConcurrentBag<string>();
            bag.Add("A");
            bag.Add("B");
            foreach(string i in bag)
            {
                Console.WriteLine(i);
            }

        }
    }
}
