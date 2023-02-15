/* 
 * Author: Kate Schryver
 * Date: 02/16/2023
 * Description: Write 2 methods and use them with user input to populate an array as long as the 
                users input and then sum the elements
 */

using System;
using System.Diagnostics.CodeAnalysis;

namespace KateSchryverDeliverable5
{
    class Program
    {
        static int[] Method1(int array_len)
        {
            Random random = new Random(); //Calling the random class
            int[] MyArray = new int[array_len]; //Creation of the array
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int Method2(int[] array)
        {
            int Method2 = 0;
            foreach(int item in array)
            {
                Method2 = Method2 + item;
            }
            return Method2;
        }
        static void Main(string[] args)
        { try
            {
                Console.WriteLine("Please enter an integer between 5 and 15:");
                int input = int.Parse(Console.ReadLine());
                int[] MainArray = Method1(input);
                if ((input >= 5) && (input <= 15))
                {
                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int element in MainArray)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + Method2(MainArray));
                }
                else
                {
                    Console.WriteLine("The input needs to be between 5 & 15.");
                    Console.WriteLine("Please enter a valid integer next time.");
                    Console.WriteLine("Press any key to exit the program and try again.");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Try again and enter a valid integer");
                Console.WriteLine("Press any key to exit the program and try again.");
                Console.ReadKey(true);
            }
        }
    }
}