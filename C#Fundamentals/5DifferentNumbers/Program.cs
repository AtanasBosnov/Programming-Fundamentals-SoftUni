using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You will be given two numbers – a and b. Generate five numbers - n1, n2, n3, n4, n5, for which the following conditions are true: a ≤ n1 < n2 < n3 < n4 < n5 ≤ b. If there is no number in the given interval, which satisfies the conditions – print “No”.
             */

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int diff = Math.Max(first,second) - Math.Min(first,second);
            if(diff<5)
            {
                Console.WriteLine("No");
            }
            
            for (int i = first; i <= second-4; i++)
            {
                for (int j = first+1; j <= second-3; j++)
                {
                    for (int k = first+2; k <=second-2; k++)
                    {
                        for (int l = first+3; l <= second-1; l++)
                        {
                            for (int m = first+4; m <= second; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
