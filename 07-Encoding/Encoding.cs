using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Encoding
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter key: ");
            string key = Console.ReadLine();
            Console.WriteLine("Enter text to encypher:");
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i]^key[i%key.Length]);
                sb.Append(" "); 
            }
            string code = sb.ToString();
            Console.WriteLine("The code is {0}",code);
            sb.Clear();
            //decoding
            int l = 0;
            string[] codeChar = code.Split(' ');
            foreach(string singleChar in codeChar)
            {
                if (sb.Length == text.Length) break;
                sb.Append((char)((char)(int.Parse(singleChar)) ^ key[l % key.Length]));
                l++;
            }
            Console.WriteLine("The decoded text is {0}", sb.ToString());

        }
    }

