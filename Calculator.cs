using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Calculator
    {
        public static Dictionary<char, int> CalculateFriquency(string text)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (char i in text){
                if(result.ContainsKey(i))
                {
                    result[i]++;
                }
                else 
                {
                    result.Add(i, 1);
                }
            }
            
            return result;
        }
    }
}
