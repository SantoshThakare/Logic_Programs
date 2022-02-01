using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Logic
    {
        int p1 = 0, p2 = 1, p3;
        public void Prob()
        {
            Console.WriteLine("Enter the Input Value");
            int count = Int32.Parse(Console.ReadLine());
            Console.WriteLine(  p1 + "\n " + p2);
            for (int i = 2; i < count; i++)
            {
                p3 = p1 + p2;
                Console.WriteLine("  " + p3);
                p1 = p2;
                p2 = p3;       
           
            }
                 Console.WriteLine();

        }

    }
   
}
