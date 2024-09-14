/* 
Coda | 2024/09/08
Topic 2 - Numbers and Math - Assignment
*/

using System;

namespace ouioui
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Hm, what year was I born again?"); // very clueless
            Console.WriteLine("");
            Thread.Sleep(2000);

            Console.WriteLine("I believe " + (2024 - 17) + "."); // answer
            Console.WriteLine("");

            Thread.Sleep(2000);
            Console.WriteLine("Also, what is the average of the sequence: 14, 15, and 16?");
            Console.WriteLine("");
            Thread.Sleep(2000);

            Console.WriteLine("I believe " + ((14 + 15 + 16) / 3) + "."); // answer
            Console.WriteLine("");

            Thread.Sleep(2000);
            Console.WriteLine("What about: 14, 15, 16, and 17?");
            Console.WriteLine("");
            Thread.Sleep(2000);

            Console.WriteLine("I believe " + ((14.0 + 15.0 + 16.0 + 17.0) / 4) + "."); // answer
            Console.WriteLine("");

            Thread.Sleep(2000);
            Console.WriteLine("What about the area of a circle with a radius of 3 cm?");
            Console.WriteLine("");
            Thread.Sleep(2000);

            Console.WriteLine(Math.Round((pi * (3 * 3)), 1) + " cm^2"); // answer
            Console.WriteLine("");

            Thread.Sleep(2000);
            Console.WriteLine("Alright, and lastly, how does c# know when to add when using the \"+\" operator instead of sticking things together?");
            Console.WriteLine("");
            Thread.Sleep(6500);

            Console.WriteLine("Through formatting of brackets. When \"+\" is inside of quotations in brackets, the addition sign will only be printed instead of actually operate a function. However, when there are no quotations around it, it will operate as expected.");
            Console.WriteLine("");

            Thread.Sleep(3000);
            Console.WriteLine("okau");
            Console.WriteLine("");
            Thread.Sleep(2000);
        }
    }
}