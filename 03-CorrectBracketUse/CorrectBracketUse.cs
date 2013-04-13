using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CorrectBracketUse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression with brackets");
            string expression = Console.ReadLine();
            int openBr = 0, closingBr = 0;
            bool flag = true;
            for (int i = 0; i < expression.Length-1; i++)
            {
                if (expression[i] == '(') openBr++;
                if (expression[i] == ')')
                {
                    closingBr++;
                    if (openBr > 0)
                    {
                        openBr--;
                        closingBr--;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                        flag = false;
                        break;
                    }
                }
            }
            if (flag&&openBr==0&&closingBr==0) Console.WriteLine("Valid");
        }
    }

