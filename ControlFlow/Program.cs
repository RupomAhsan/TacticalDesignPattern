using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tactical Design Pattern - Pluralsight");
            // ControlFlowDemo1();
            // ControlFlowDemo2();
            NullReferenceDemo1();
        }

        private static void NullReferenceDemo1()
        {
            Discount aDiscount = new Discount("loyalty discount", .15M);

            Console.WriteLine("NUll Reference - Demo 1 -->>");
            Console.WriteLine("{0:C}", GetItemPrice("laptop", aDiscount));
            Console.WriteLine("{0:C}", GetItemPrice("pen"));
            Console.ReadLine();
        }

        private static decimal GetItemPrice(string itemName, Discount aDiscount)
        {
            if(aDiscount == null)
            {
                throw new ArgumentNullException(nameof(aDiscount));
            }
            decimal basePrice = GetItemPrice(itemName);
            Console.WriteLine("LOG applying {0}", aDiscount);
            return aDiscount.Apply(basePrice);
        }

        private static void ControlFlowDemo2()
        {
            Console.WriteLine("Control Flow - Demo 2 -->>");
            Console.WriteLine("{0:C}", GetItemPrice("laptop", .15M));
            Console.WriteLine("{0:C}", GetItemPrice("pen"));
            Console.ReadLine();
        }
        private static decimal GetItemPrice(string itemName)
        {
            return 100.0M * itemName.Length;
        }

        private static decimal GetItemPrice(string itemName, decimal relativeDiscount)
        {
            if(relativeDiscount<0 || relativeDiscount >= 1)
            {
                throw new ArgumentException("Incorrect dscount", "relativeDiscount");
            }
            Console.WriteLine("LOG Discount {0}% applied", 100 * relativeDiscount);
            return GetItemPrice(itemName)* (1.0M - relativeDiscount);
        }

        private static void ControlFlowDemo1()
        {
            Console.WriteLine("Control Flow - Demo 1 -->>");
            Console.WriteLine("Please Enter a number here:");
            long number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Results:" + CalculateControlDigit(number));
            Console.ReadLine();
        }

        private static int CalculateControlDigit(long number)
        {
            int sum = 0;
            int pos = 1;

            do
            {
                int digit = (int)(number % 10);

                if (pos % 2 == 0)
                    sum += 3 * digit;
                else
                    sum += digit;

                number /= 10;
                pos++;
            }
            while (number > 0);

            int result = sum % 11;
            if (result == 10)
                result = 1;

            return result;
        }

        
    }
}
