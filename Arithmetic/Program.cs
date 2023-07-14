
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;



            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());



            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());



            Addition addTest = new Addition(num1, num2);
            addTest.Sum();

            Subtraction subTest = new Subtraction(num1, num2);
            subTest.Difference();

            Multiplacation timesTest= new Multiplacation(num1, num2);
            timesTest.Product();

            Division dividTest = new Division(num1, num2);
            dividTest.Quotient();

            Console.ReadLine();
        }
    }
    class Addition
    {
        public int addnumber1;
        public int addnumber2;

        public Addition(int num1, int num2)
        {
            addnumber1 = num1;
            addnumber2 = num2;
        }

        public void Sum()
        {
            Console.WriteLine("Sum is " + (addnumber1 + addnumber2));
        }
    }
    class Subtraction
    {
        public int subnumber1;
        public int subnumber2;

        public Subtraction(int num1, int num2)
        {
            subnumber1 = num1;
            subnumber2 = num2;
        }

        public void Difference()
        {
            Console.WriteLine("Difference is " + (subnumber1 - subnumber2));
        }

    }
    class Multiplacation
    {
        int timesnumber1;
        int timesnumber2;

        public Multiplacation(int num1, int num2)
        {
            timesnumber1 = num1;
            timesnumber2 = num2;
        }

        public void Product()
        {
            Console.WriteLine("Product is " + (timesnumber1 * timesnumber2));
        }

    }
    class Division
    {
        int dividenum1;
        int dividenum2;

        public Division(int num1 , int num2)
        {
            dividenum1 = num1;
            dividenum2 = num2;
        }

        public void Quotient()
        {
            Console.WriteLine("Quotient is " + (dividenum1 / dividenum2));
        }
    }

}