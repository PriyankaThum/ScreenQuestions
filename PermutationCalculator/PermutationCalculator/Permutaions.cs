using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationCalculator
{
    class Permutaions
    {
        public void permutationsexp()
        {
            Console.WriteLine("Enter any number");
            string str1 = Console.ReadLine();
            char[] str = str1.ToCharArray();
            int count = 0;
            int numOfPermutations = str1.Length * (str1.Length - 1);
            while (count <= numOfPermutations - 1)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    char c = str[i];
                    str[i] = str[i + 1];
                    str[i + 1] = c;
                    Console.WriteLine(str);
                    count++;
                }
            }
        }
    }
}
