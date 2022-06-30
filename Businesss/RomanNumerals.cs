using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RomanNumerals
    {

        private static readonly Dictionary<char, int> Map = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 },
            };
        public static int GetArabicNumerals(string romanNumber)
        {
            int answer = 0;
            for (int i = 0; i < romanNumber.Length; i++)
            {
                if (i + 1 < romanNumber.Length && SubstractiveCase(romanNumber[i], romanNumber[i + 1]))
                    answer -= Map[romanNumber[i]];
                
                else
                    answer += Map[romanNumber[i]];
            }
            return answer;
        }

        private static bool SubstractiveCase(char a, char b)
        {            
            return Map[a] < Map[b];            
        }
    }


}