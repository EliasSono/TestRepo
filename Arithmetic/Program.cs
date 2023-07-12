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

            Addition addTest = new Addition();

            addTest.GetNumber1();
            addTest.GetNumber2();
            addTest.Sum();

            Console.Write("This is a test!");
            Console.ReadLine();
        }
    }
    class Addition
    {
        int number1;
        int number2;

        public void GetNumber1()
        {
            Console.Write("Enter first number: ");
            number1 = int.Parse(Console.ReadLine());
        }
        public void GetNumber2()
        {
            Console.Write("Enter second number: ");
            number2 = int.Parse(Console.ReadLine());
        }
        public void Sum()
        {
            Console.WriteLine("Sum is " + (number1 + number2));
        }
    }

}
