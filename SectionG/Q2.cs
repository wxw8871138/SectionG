using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionG
{
    class Q2
    {
        static void Main()
        {
            q2();
        }
        static void q2()
        {
            Console.WriteLine("Question 2:");
            Console.Write("Enter a sentence:");
            string input = Console.ReadLine();
            input = input.ToUpper();
            Console.WriteLine(input);
            string s="";
            for(int i = 0; i < input.Length; i++)
            {
                if (65 <= input[i] && input[i] <= 90)
                {
                    s = s + input[i];
                }
            }
            Console.WriteLine(s);
            for (int i = 0; i <= s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    Console.WriteLine("It's not a palindrome");
                    return;
                }
            }
            Console.WriteLine("It's a palindrome");
        }
        
    }
}