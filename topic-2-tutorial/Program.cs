/* 
Coda | 2024/09/08
Topic 2 - Numbers and Math - Lesson Tutorial
*/

using System;

namespace yesyes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("six" + 6); // Prints "six6"
            Console.WriteLine("6 + 6"); // Prints "6 + 6"
            Console.WriteLine("6" + 6); // Prints "66"
            Console.WriteLine(6 + 6); // Prints "12"
            Console.WriteLine("");

            Thread.Sleep(2000);

            Console.WriteLine("Now I will count ze eggs:");
            Thread.Sleep(2500);
            Console.WriteLine(11 / 2);
            Thread.Sleep(3000);
            Console.WriteLine("Wait, that is not right... Here, this is the correct count:");
            Thread.Sleep(5000);
            Console.WriteLine(11.0 / 2);
            Console.WriteLine("");
            
            Thread.Sleep(3500);

            Console.WriteLine("Is it true that 3 + 2 < 5 - 7?");
            Thread.Sleep(3500);
            Console.WriteLine(3 + 2 < 5 - 7);
            Thread.Sleep(3000);
            Console.WriteLine("Hm...");
            Thread.Sleep(5000);
            Console.WriteLine("What is 3 + 2? " + (3 + 2));
            Thread.Sleep(2000);
            Console.WriteLine("What is 5 - 7? " + (5 - 7));
            Thread.Sleep(5000);
            Console.WriteLine("Ah, so zat is why it is " + (3 + 2 < 5 - 7));
            Thread.Sleep(2000);
            Console.WriteLine("Yes, yes!");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Thread.Sleep(2000);

            /* The reason that putting mathematical expressions inside the double quotes will not execute the expression,
            is because anything inside the quotes will be printed as plain text, and not executed as a function. */
            
            Console.WriteLine("Hm, how much money would you earn if you worked for 8 hours, earning $21 an hour?");
            Thread.Sleep(3000);
            Console.WriteLine((21 * 8).ToString("C"));
            Thread.Sleep(3000);
            Console.WriteLine("What about, how much an egg would cost if it costs $6 for a dozen eggs?");
            Thread.Sleep(3000);
            Console.WriteLine((6.0 / 12).ToString("C"));
            Thread.Sleep(3000);
            Console.WriteLine("What if, you had a 13% tax on an item which costs 79.99$?");
            Thread.Sleep(3000);
            Console.WriteLine(((79.99 * 0.13) + 79.99).ToString("C"));
            Thread.Sleep(3000);
            Console.WriteLine("Hoho... Now, calculate how many centimeters are in 5'6\"");
            Thread.Sleep(3000);
            Console.WriteLine((((5 * 12) + 6) * 2.54) + " cm");
            Thread.Sleep(3000);
            Console.WriteLine("oh, okau");
            Thread.Sleep(2000);
        }
    }
}