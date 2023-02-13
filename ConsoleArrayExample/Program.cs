using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating and Initializing an Array of Integers
            //Size of the Array is 10
            int[] Numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };
            //Printing the Array Elements using a for Loop
            Console.WriteLine("Original Array Elements :");
            Numbers[0] = 100; // Assigning new value to the first element of array
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
            Console.WriteLine();
            //Sorting the Array Elements by using the Sort method of Array Class
            Array.Sort(Numbers);
            //Printing the Array Elements After Sorting using a foreach loop
            Console.WriteLine("\nArray Elements After Sorting :");
            foreach (int i in Numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Reversing the array elements by using the Reverse method of Array Class
            Array.Reverse(Numbers);
            //Printing the Array Elements in Reverse Order
            Console.WriteLine("\nArray Elements in the Reverse Order :");
            foreach (int i in Numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Creating a New Array
            int[] NewNumbers = new int[10];
            //Copying Some of the Elements from Old array to new array
            //We declare the array with size 10 and we copy only 5 elements. 
            //So the rest 5 elements will take the default value. In this array, it will take 0
            Array.Copy(Numbers, NewNumbers, 5);
            //Printing the Array Elements using for Each Loop
            Console.WriteLine("\nNew Array Elements :");
            foreach (int i in NewNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"\nNew Array Length using Length Property :{NewNumbers.Length}");
            Console.WriteLine($"New Array Length using GetLength Method :{NewNumbers.GetLength(0)}");
            Console.ReadKey();
        }
    }
}
