using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class IsPalindrome_Result
    {
        public string IsPalindrome(string str)
        {
            int MaxLength = str.Length;
            int Range = Convert.ToInt32(Math.Floor(Convert.ToDecimal(MaxLength) / 2));
            int Length = MaxLength - 1;
            for (int i = 0; i < Range; i++)
            {
                if (str[i] != str[Length - i])
                    return "Not Palindrome!";
            }
            return "Palindrome!";
        }
    }

    internal class IsPalindrome_Solution
    {
        public static void Input()
        {
            //string str = "KAYAK";
            //string str = "MADAM";
            //string str = "REFER";
            //string str = "REDIVIDER";
            //string str = "NOON";
            string str = "PLANET";
            IsPalindrome_Result objResult = new IsPalindrome_Result();
            string result = objResult.IsPalindrome(str);
            Console.WriteLine($"{str} is {result}");
        }
    }
}
