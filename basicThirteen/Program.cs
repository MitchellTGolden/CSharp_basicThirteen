﻿using System;

namespace basicThirteen
{
    class Program
    {

        // Print 1-255
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (var i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Print odd numbers between 1-255
        public static void PrintOdds()
        {
            for (var i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Print Sum
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            var sum = 0;
            for (var i = 1; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }


        // Iterating through an Array
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }


        // Find Max
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }


        // Get Average
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Average: {sum / numbers.Length}");
        }
        // Array with Odd Numbers

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int count = 0;
            for (var i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            int[] newArr = new int[count];
            int pos = 0;
            for (var i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    newArr[pos] = i;
                    pos++;
                }
            }
            return newArr;
        }


        // // Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    count++;
                }
            }
            return count;
        }


        // Square the Values
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        // Eliminate Negative Numbers
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        // Min, Max, and Average
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                else if (num < min)
                {
                    min = num;
                }
                sum += num;

            }
            Console.WriteLine($"Max: {max}, Min: {min}, Average: {sum / numbers.Length}");

        }

        // Shifting the values in an array
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (var i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    numbers[i] = 0;
                }
                else
                {
                    numbers[i] = numbers[i + 1];
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        // Number to String
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] objArr = new object[numbers.Length];
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    objArr[i] = numbers[i];
                }
                else
                {
                    objArr[i] = "Dojo";
                }
            }
            return objArr;
        }
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] numberz = { 1, 2, 3, 4, 5, 6 };
            LoopArray(numberz);
            int[] findMax = { -3, -5, -7 };
            Console.WriteLine(FindMax(findMax));
            int[] avgArr = { 2, 10, 3 };
            GetAverage(avgArr);
            // int[] odds = OddArray();
            // Console.WriteLine("[{0}]", string.Join(", ", odds));
            Console.WriteLine("[{0}]", string.Join(", ", OddArray()));
            int[] gTY = { 1, 3, 5, 7 };
            Console.Write(GreaterThanY(gTY, 3));
            int[] sqVal = { 1, 5, 10, -10 };
            SquareArrayValues(sqVal);
            int[] elNeg = { 1, 5, 10, -2 };
            EliminateNegatives(elNeg);
            int[] mMA = { 1, 5, 10, -2 };
            MinMaxAverage(mMA);
            int[] shifted = { 1, 5, 10, 7, -2 };
            ShiftValues(shifted);
            int[] nToStr = { -1, -3, 2 };
            Console.WriteLine("[{0}]", string.Join(", ", NumToString(nToStr)));
        }
    }
}
