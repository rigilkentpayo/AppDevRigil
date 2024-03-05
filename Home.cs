using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class Home
    {
        private double price, interest, percent;

        static void main(string[] args)
        {
            Home h = new Home();
            h.InputValues();
            h.Display();
        }
        public void InputValues()
        {
            Console.WriteLine("Price of Home      >>");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Interest Rate      >>");
            interest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Percent as Down Payment      >>");
            percent = Convert.ToDouble(Console.ReadLine());
        }

        public double DownPayment(double price, double percent)
        {
            double down = price * percent /100;
            return down;
        }
        public double FinancedAmount(double price, double percent)
        {
            double fin = price * percent/100;
            double finfin = price - fin;
            return finfin;
        }
        public double MonthlyPayment(double interest)
        {
            double Monthly_Amount = interest / 100 / 12;
            return FinancedAmount(price, percent) * Monthly_Amount / (1 - Math.Pow(1 + Monthly_Amount, -360));
        }
        public double TotalInterest(double price, double interest)
        {
            return (MonthlyPayment(interest) * 360) - price - 0.01;
        }
        public void Display()
        {
            Console.WriteLine($"Down Payment       : ${DownPayment(price, percent)}");
            Console.WriteLine($"Amount Payment     : ${FinancedAmount(price, percent)}");
            Console.WriteLine($"Monthly Payment    : ${MonthlyPayment(interest)}");
            Console.WriteLine($"Total Interest     : ${TotalInterest(price, interest)}");
        }
    }
}

