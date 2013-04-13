using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SubstringSearch
    {
        static void Main(string[] args)
        {
            string text="We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine("In the text: {0}",text);
            Console.WriteLine("what substring should we search for?");
            string substr=Console.ReadLine();
            int counter=0;
            text=text.ToLower();
            substr=substr.ToLower();
            for (int i = 0; i < text.Length-1; i++)
			{
			 if(text.IndexOf(substr,i)>-1)
             {
                 counter++;
                 i=text.IndexOf(substr,i);
             }
			}
            Console.WriteLine("There are {0} encounters of the string {1} in the text",counter,substr);
        }
    }

