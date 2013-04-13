using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class StringReverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a words to reverse");
            string word = Console.ReadLine();
            StringBuilder strBld = new StringBuilder();
            for (int i = word.Length-1; i >= 0; i--)
			{
                strBld.Append(word[i]);
			}
            Console.WriteLine("The new word is {0}",strBld.ToString());
        }
    }

