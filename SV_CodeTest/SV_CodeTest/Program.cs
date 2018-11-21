using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_CodeTest
{
   public class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            Console.Write("Enter the number of participants(n): ");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the game factor(k): ");
            var k = Convert.ToInt32(Console.ReadLine());
            var res = Game(num, k);
            if (res.Success)
            {

                Console.WriteLine("The winner is- ID: {0}", res.Winner.ID);            
                Console.WriteLine("---The list of children out from the game in the order of occurance---");
                for (int i = 0; i < res.Out.Count; i++)
                {
                    Console.WriteLine( (i+1) +". ID- {0}", res.Out.GetChild(i).ID);
                }                
            }
            else
            {
                Console.Write(res.ErrorMsg);
            }
            // Wait for user
            Console.ReadKey();
        }

        public static Result Game(int n,int k)
        {
            Children collection = new Children();
            Children outList = new Children();
            Dictionary<Child, Children> result = new Dictionary<Child, Children>();
            for (int i = 1; i <= n; i++)
            {
                collection[i] = new Child(i);                           // O(n) operation depends on the number of inserts to the ArrayList collection
            }
            // Create iterator
            Iterator iterator = collection.CreateIterator();
            // Skip every other item
            iterator.Step = k;
            if (n > 0 && k > 0)
            {
               
                for (Child item = iterator.First();
                    !iterator.IsDone; item = iterator.Next())
                {
                    outList.Add(item);                                  // O(1) operation as the item is inserted
                }

                Child winner = collection.winner();
                return new Result() { Success = true, ErrorMsg = null, Winner = winner, Out = outList };

            }
            else
            {
                return new Result() { Success = false, ErrorMsg = "Invalid number of participants or game factor" };
            }
            
        }
    }
}
