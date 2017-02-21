using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
    class Program
    {
        int age = 0;
        public int CalculateCustomerAge(DateTime Dob, DateTime Now)  
        {
            age = Now.Year - Dob.Year;
            if (Now.Month < Dob.Month || (Now.Month == Dob.Month && Now.Day < Dob.Day))
                age--;
            return age;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("********* Welcome to the Age Verification for Purchasing Liquor *********");
            Console.WriteLine("Please Enter the Date Of Birth of the Customer");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Program ageverification = new Program();
           int Result = ageverification.CalculateCustomerAge(dob, DateTime.Today);
            bool adult = Result >= 18 ? true : false;
            if(adult== true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Customer is Eligible to purchase liquor \n ********* THANK YOU *********");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Customer is Not Eligible to purchase liquor And Selling liquor to Underage is Crime \n ********* THANK YOU *********");
            }
            Console.ReadKey();
        }
    }
}
