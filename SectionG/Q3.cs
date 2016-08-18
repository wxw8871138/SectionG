using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionG
{
    class Q3
    {
        static void Main()
        {
            q3();
        }
        static void q3()
        {
            Console.WriteLine("Question 3:");
            Console.Write("Enter a sentence:");
            string input = Console.ReadLine();
            char[] s = input.ToCharArray();
            string ss = "";
            ss = ss + s[0].ToString().ToUpper();
            for (int i = 1; i < input.Length; i++)
            {
                if (s[i - 1] == ' ')
                {
                    ss = ss+s[i].ToString().ToUpper();
                }
                else
                {
                    ss = ss + s[i];
                }

            }
            Console.WriteLine(ss);
        }
    }
}
