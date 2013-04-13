using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class UpCaseTags
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            StringBuilder sb = new StringBuilder();
            int startInd = 0, endInd = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text.IndexOf("<upcase>", i) > -1)
                {
                    startInd = text.IndexOf("<upcase>", i) + 8;
                    endInd = text.IndexOf("</upcase>", i) ;
                    sb.Append(text.Substring(i,startInd-1-i-7));
                    sb.Append(text.Substring(startInd, endInd - startInd).ToUpper());
                    i = endInd + 8;
                }
            }
            sb.Append(text.Substring(endInd + 9, text.Length-1-endInd-8));
            Console.WriteLine(sb.ToString());
        }
    }
