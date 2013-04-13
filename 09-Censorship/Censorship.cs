using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Censorship
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            Console.WriteLine("Enter words to censor, separetaed by coma");
            string censorList = Console.ReadLine();
            string[] censorWords = censorList.Split(',', ' ');
            StringBuilder sb = new StringBuilder();
            foreach (var badWord in censorWords)
            {
                if(badWord.Length!=0)
                    text=text.Replace(badWord, sb.Append('*', badWord.Length).ToString());
                sb.Clear();
            }
            Console.WriteLine("The new text is {0}",text);
        }
    }

