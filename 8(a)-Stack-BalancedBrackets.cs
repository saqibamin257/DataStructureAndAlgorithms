using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class BalancedBrackets_Result
    {
        public bool BalancedBrackets(string str)
        {
            //if length is not even return false
            if (str.Length % 2 != 0)
            {
                return false;
            }

            //we need generic stack of type char as bracket are characters
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>();

            // Add open brackets as key and closed bracket as value in doctionary
            dict.Add('(', ')');
            dict.Add('[', ']');
            dict.Add('{', '}');

            //if dictioanry contains current bracket(open) as key then add in stack
            //else compare current bracket with getKey of dictionary value, if same then pop from stack and continue

            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    stack.Push(str[i]);
                }

                else if (dict.ContainsValue(str[i]))
                {
                    if(stack.Count == 0)
                    return false;
                    char ch = stack.Pop();
                    if (ch != dict.FirstOrDefault(x => x.Value == str[i]).Key) //compare key of both
                    {
                        return false;
                    }                    
                }               
            }
            return stack.Count == 0 ? true : false;
        }
    }

    internal class BalancedBrackets_Solution
    {
        public void Input() 
        {
            string str = "{(([])){{}}";
            //string str = "{(([]))}";
            if(new BalancedBrackets_Result().BalancedBrackets(str)) 
            {
                Console.WriteLine($"\n {str} is balanced");
            }
            else 
            {
                Console.WriteLine($"\n {str} is not balanced");
            }
        }
    }
}
