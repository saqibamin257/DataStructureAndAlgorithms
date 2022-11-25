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
            int MinLength = 1;
            int Range = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(MinLength + MaxLength) / 2));
            for(int i=0; i<Range-1; i++) 
            {
                if (checkLeft(str[i],str,i) != checkRight(str[i], str, i)) 
                {
                    return "Not Palindrome!";
                }                
            }
            return "Palindrome!";
        }

        internal bool checkLeft(char ch, string str, int index) 
        {
            if (str[index] == ch)
                return true;
            else
                return false;
        }
        internal bool checkRight(char ch, string str, int index)
        {
            int length = str.Length-1;
            if (str[length - index] == ch)
                return true;
            else
                return false;
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
