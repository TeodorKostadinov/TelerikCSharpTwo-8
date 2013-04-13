using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class TwentCharString
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int j = 0;
            if(line.Length>20)  line = line.Remove(20, line.Length - 21);
            StringBuilder sb=new StringBuilder();
            for (int i = 0; i < 20; i++)
            {
                if (j < line.Length)
                {
                    sb.Append(line[j]);
                    j++;
                }
                else
                    sb.Append('*');
            }
            Console.WriteLine(sb.ToString());
        }
    }

