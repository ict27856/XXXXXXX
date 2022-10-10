using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Console;

namespace mod5assgn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Welcome to my method examples ^_^");

            WriteLine("Check this out!");
            secretNumber();

            WriteLine("Next...");
            localTaxRate();


            ReadKey();

        }   

            static int secretNumber()
            {
                int secretNum = 72;
                WriteLine("The secret number is ", secretNum, "!");

                return secretNum;
            }


            static int localTaxRate()
            {
                int taxRate;
                WriteLine("Please enter your local tax rate");
                taxRate = Convert.ToInt32(ReadLine());

                WriteLine("Your tax rate is " + taxRate);
                return taxRate;
            }
            

    }

}

