﻿using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();


            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            int num = 0;
            List<int> list1 = new List<int>(){ 12, 13, 14, 15, 16 };




            // Create a do-while loop and use the template below:

            {
                // Increment num by 1

                // Then add num to the collection - numbers
                    // Hint: reference num inside of the Add method's parentheses
                //numbers.Add(/* num */);

            } // <---- While your variable is less than 100





            //do
            //{
            //
            //    Console.WriteLine(numbers [num]);
            //    num++;
            //
            //} while (num < 100);


            // Create a while loop
            // <--- While num is less than 200
            {
                // Increment num by 1
                // Then add num to the collection numbers
                    //HINT: copy how this was done in the do while loop

            }
            int index = 0;
            while (index <4)
            {
                Console.WriteLine(index);
                numbers.Add(index);
                index++;    
            }



            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers
             foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1
            
            for (int i = 199; i >= 0;)
            {
                Console.WriteLine(i);
                
                
                
            }

            //------------End of exercise
            //for (int i = 0; i < 5; i++)
            //{
             //   Console.WriteLine($"{i}");
            //}
            //
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i  = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{1}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i ++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{i}");
            //}
        }   
    }
}





       