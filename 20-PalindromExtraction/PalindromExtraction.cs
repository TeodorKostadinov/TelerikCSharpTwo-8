using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class Program
{
    static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
            if ((str[i] != str[str.Length - 1 - i]) && (str[i] != '3' || str[i] != '5'))
                return false;

        return true;
    }
    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        string[] input = line.Split(' ');
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);
        string inputed = Console.ReadLine();
        string[] strNums;
        strNums = inputed.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        long[] list = new long[strNums.Length];
        int numElem = 0;
        foreach (var num in strNums)
        {
            list[numElem] = long.Parse(num);
            numElem++;
        }
        int p = int.Parse(Console.ReadLine());
        Array.Sort(list);

        long swap;
        int count = 0;
        if (a > b)
        {
            swap = a;
            a = b;
            b = swap;
        }

        for (long j = (a - 1) / 2; j <= b / 2; j++)
        {
            long i = 2 * j + 1;
            string str = i.ToString();
            byte firstDigit = byte.Parse(str.Substring(0, 1));
            if (firstDigit == 3 || firstDigit == 5)
            {
                foreach (Match item in Regex.Matches(str, @"\w+"))
                    if (IsPalindrome(item.Value)) count++;
            }
            else
            {
                if (str.Length > 1)
                {
                    if (firstDigit > 3 && firstDigit < 5) { firstDigit = 5; string novStr = firstDigit.ToString() + str.Substring(1); i = long.Parse(novStr); }
                    if (firstDigit < 3) { firstDigit = 3; string novStr = firstDigit.ToString() + str.Substring(1); i = long.Parse(novStr); }
                    if (firstDigit > 5) i = 3 * (long)Math.Pow(10, (str.Length));
                }
            }

        }
        Console.WriteLine(count);
        if(p>=50)
        Console.WriteLine(list[((p * numElem) / 100)-1]);
    }
}