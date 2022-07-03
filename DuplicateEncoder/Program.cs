using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateEncoder
{
    internal class Program
    {

        // The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that 
        // character appears only once in the original string, or ")" if that character appears more than once in the original string.
        // Ignore capitalization when determining if a character is a duplicate.

      // Цель этого упражнения — преобразовать строку в новую строку, где каждый символ в новой строке — это «(», если это
      // символ появляется только один раз в исходной строке или ")", если этот символ встречается в исходной строке более одного раза.
      // Игнорировать заглавные буквы при определении, является ли символ дубликатом.
        static void Main(string[] args)
        {
			string word = "Hello";
			Console.WriteLine(Duplicate(word));
            Console.ReadLine();
		}

        public static string Duplicate(string word)
        {
            string result = "";
            word = word.ToLower();
            foreach (char c in word)
            {
                if (word.Count(w => w == c) > 1)
                    result += ")";
                else
                    result += "(";
            }
            return result;
        }
	}
}
    
