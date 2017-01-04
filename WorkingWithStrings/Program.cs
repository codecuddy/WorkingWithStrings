using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "I want this on \ntwo lines, not one!";  // \n does a new line
            //string myString = "Go to your c:\\ drive";  // use a second \ to escape out of it and show \
            //string myString = @"Go to your c:\ drive";
            //string myString = string.Format("You are {0} years old and born in {1}", "29", "June");  //change order of {n} if wanted
            //string myString = string.Format("{0:C}", 69.75);  //:C does currency
            //string myString = string.Format("{0:N}", 1234567890); //:N adds in , and . to two spots in appropriate spot for big numbers
            //string myString = string.Format("Percentage: {0:P}", .875); //:P displays as percent
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 4024834506); // custom format 

            //string myString = " That summer we took threes across the board  ";
            //myString = myString.Substring(6);
            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "---");
            //myString = myString.Remove(6, 14);
            /*
            myString = String.Format("Length Before: {0} -- After Length: {1}",
                myString.Length, 
                myString.Trim().Length);       //Time takes off spaces at start and end, also TrimEnd and others
            */

            /*
            string myString = "";
            for (int i = 0; i < 101; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            //more efficient way of doing the exact same thing as the for loop directly above
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 101; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
