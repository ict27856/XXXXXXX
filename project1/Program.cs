using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string address;
            string dateOfTravel;
            double grandTotal;
            int subTotal;

            //qs
            WriteLine("Please enter your name.");
            userName = Console.ReadLine();

            WriteLine("Please enter your address");
            address = Console.ReadLine();

            WriteLine(userName + ", please enter your date of travel in the MM/DD/YYYY format.");
            dateOfTravel = Console.ReadLine();

            WriteLine(userName + ", your address is: " + address + ", and your date of travel is: " + dateOfTravel + ".");
           
            //math! 

            subTotal = Baggagestuff() + Seats();

            //reciept begins here

            WriteLine("[ " + userName + ", your subtotal is . . . $" + subTotal + " ]");
            grandTotal = subTotal * 0.05 + subTotal;
            WriteLine("[ " + userName + ", your grant total is . . . $" + grandTotal + " ]");
            WriteLine("Thank you for using our services today, " + userName + "! . . .");

            //reciept ends 

            ReadKey();
        }
        public static int Baggagestuff()
        {
            int bagAmount;
            int total;
            string userAnswer;

            WriteLine("Please input the amount of bags you're carrying.");
            bagAmount = Convert.ToInt32(ReadLine());

            WriteLine("Do you want to check your bags? [Yes/No]");

            userAnswer = ReadLine();

            total = bagAmount * 25;

            if (userAnswer == "Yes")
            {

                WriteLine("Your total is $" + total);
                
            }
            else
            {
                WriteLine("You're bringing " + bagAmount + " bags.");
            }
            return total;
        }

        public static int Seats()
        {
            int seatTotal;
            int seatAmount;
            string userAnswerSeat;

            WriteLine("Please enter the amount of seats you want.");
            seatAmount = Convert.ToInt32(ReadLine());
            WriteLine("You requested " + seatAmount + " seats.");

            WriteLine("Would you like to pay for seats? [Yes/No]");
            userAnswerSeat = ReadLine();
            seatTotal = seatAmount * 30;
            if (userAnswerSeat == "Yes")
            {
   
                WriteLine("Your total for " + seatAmount + "seats is $" + seatTotal);
                
            }
            else
            {
                WriteLine("You chose not to pay for" + seatAmount + " seats.");
            }
            return seatTotal;
        }
    }
}
