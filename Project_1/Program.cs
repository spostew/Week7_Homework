/*
 * Counter: This program uses functions to increase or decrease the the value of an int in the main function.
 * Name: Spencer Unitt
 * Module: Homework 7 
 * Problem statement: Create a counter class that tracks the value of an int
 * 
 * Algorithm: 
 * 1. Create a class named counter with a single int and the following functions
 *    a. A constructor that sets the int to 0
 *    b. A setToZero function that sets the value to 0
 *    c. An increase function that increments the int by 1 
 *    d. A decrease function that lowers the int by 1
 *    e. A getter function that return the current value of the int.
 *    f. A toString and equals function
 * 2. In the main function create an object of the counter class and call the tostring showing the current value.
 * 3. Test each function by adding and taking away values from the object. Use toString to show each change.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter test = new Counter(); // Creates new counter object
            Console.WriteLine(test.ToString()); // Shows the first value, should be 0

            test.increase(); // Sets the value to + 1
            Console.WriteLine(test.ToString());

            test.increase(); // + 1
            Console.WriteLine(test.ToString());

            test.decrease(); // - 1
            Console.WriteLine(test.ToString());

            test.decrease(); // - 1
            Console.WriteLine(test.ToString());

            test.decrease(); // - 1 / In this case the value will drop below 0 so the value is just kept at 0 instead
            Console.WriteLine(test.ToString());

            for(int i = 0; i < 5; i++) // Uses the increase function 5 times
            {
                test.increase();
            }
            Console.WriteLine(test.ToString());

            test.setToZero(); // resets the value
            Console.WriteLine(test.ToString());

            Console.ReadLine(); // holds the screen until user clicks away


        }
    }
}
