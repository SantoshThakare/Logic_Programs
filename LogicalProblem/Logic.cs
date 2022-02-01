using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Logic
    {                                                              
        public  void prob()
        {
            int num = 1234;
            int Result = 0;
            int rem;
            while (num != 0)
            {
                rem =num % 10;
                Result = Result * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine($"{Result} ");
            Console.ReadLine(); 
        }


    }
   
}
        