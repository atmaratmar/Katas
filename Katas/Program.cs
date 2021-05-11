using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
          string str=  Console.ReadLine();
            Console.WriteLine(ToCamelCase(str));
        }

        public static string ToCamelCase( string text)
        {
            char[] letters = text.ToLower().ToCharArray();

            for (int i = 0; i < letters.Count(); i++)
            {
                letters[i] = i == 0 || letters[i - 1] == ' ' ? 
                    char.ToUpper(letters[i]) : letters[i];

            }
           string result=  string.Join("", letters);
            return result.Replace(" ", string.Empty);
        }
    }
   
}
