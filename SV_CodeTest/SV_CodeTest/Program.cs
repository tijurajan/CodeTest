using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            int n = 10;
            int k = 3;
            Children collection = new Children();
            Children outList = new Children();
            for (int i = 1; i <= n; i++)
            {
                collection[i] = new Child(i);
            }
            // Create iterator
            Iterator iterator = collection.CreateIterator();
            // Skip every other item
            iterator.Step = k;

            Console.WriteLine("Iterating over children:");

            for (Child item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                outList.Add(item);
            }
            Child winner = collection.winner();

            // Wait for user

            Console.ReadKey();
        }
    }
}
