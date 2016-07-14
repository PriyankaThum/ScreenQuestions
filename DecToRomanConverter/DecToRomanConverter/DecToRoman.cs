using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToRomanConverter
{
    class DecToRoman
    {
        public void decimaltoroman()
        {
            Console.WriteLine("Enter a decimal number");
            int input = int.Parse(Console.ReadLine());
            string[] output = new string[10];
            int x = 0;
            Dictionary<int, string> table = new Dictionary<int, string>()
            {
             {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"}, {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"}, {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
            };
            while (input >= 1)
            {
                foreach (var i in table)
                {
                    if (input >= i.Key)
                    {
                        input -= i.Key;
                        output[x] += i.Value;
                        x++;
                        break;
                    }
                }
            }
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
            }

        }
    }
}
