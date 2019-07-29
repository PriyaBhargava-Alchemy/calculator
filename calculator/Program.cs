using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, ans = 0;
            char symbol;
            Console.WriteLine("Enter Number 1 :");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number 2 :");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What do you want to do this number add, sub, multi or Div ?  :");
            symbol = Convert.ToChar(Console.ReadLine());
          //  ans = Convert.ToDouble(Console.WriteLine());
            if (symbol == '+')
            {
                ans = num1 + num2;
            }
            else if (symbol == '-')
            {
                ans = num1 - num2;
            }
            else if (symbol == '*')
            {
                ans = num1 * num2;
            }

            else if (symbol == '/')
            {
                ans = num1 / num2;
            }
            else

                Console.WriteLine("You are not enter correct symbol Sorry i cant find it:");
            Console.WriteLine("num1   =  " + num1);
            Console.WriteLine("num2   =  " + num2);
            Console.WriteLine("You pick this Symbol  = " + symbol);
            Console.WriteLine(num1  + "  " + symbol + "  " + num2);
            Console.WriteLine("Ans   =  " + ans);
            Console.ReadKey();
            
        }

     //   MethodAccessException for Print

        //public String void Print()
        //{
        //    String p = "  ";
        //    p = Console.WriteLine(p);
        //}

    }
}
