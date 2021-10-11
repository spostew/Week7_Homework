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
    public class Counter
    {
        
        int count;

        public Counter() // Constructor
        {
            count = 0;
        }

        public void setToZero() // Function that sets the value to 0
        {
            count = 0;
        }

        public void increase() // Function will increase the value by 1
        {
            count++;
        }

        public void decrease() // decrease will lower the value by 1. If the value is already zero or less than just set value to 0
        {
            if(count <= 0)
            {
                count = 0;
            }
            else
            {
                count--;
            }
            
        }

        public int getCount() // Getter
        {
            return count;
        }

        public override string ToString() // Tostring will print out the string below when called
        {
            return "Your current count is: " + count;
        }

        public override bool Equals(object obj) // Equals function
        {
            return base.Equals(obj);
        }

    }
}
