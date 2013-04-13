using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SentenceExtraction
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine("Enter separater, try in");
            string separator=" "+Console.ReadLine()+" ";
            StringBuilder sb =new StringBuilder();
            while (text.Length != 0)
            {
                int dotInd=text.IndexOf(".");
                int separetorInd = text.IndexOf(separator);
                if (dotInd < separetorInd)
                    text=text.Remove(0, dotInd+1);
                else
                {
                    sb.Append(text.Substring(0, dotInd+1));
                    text=text.Remove(0, dotInd+1);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }

