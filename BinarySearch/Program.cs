using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search!");
            Console.WriteLine("--------------");

            int[] array = ArrayUtility.GetArrayFromInputElements();
            if (ArrayUtility.isSortedArray(array))
            {
                Console.WriteLine("Enter the element to be searched in the sorted array");
                try
                {
                    int elementToSearch = int.Parse(Console.ReadLine());
                    ArrayUtility.BinarySearch(array, elementToSearch);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Thrown exception is " + exception.Message);
                }
            }
            else {

                Console.WriteLine("Entered array is not sorted!");
                Console.WriteLine("Binary Search can only work in a sorted array!");
            }
            Console.ReadLine();
        }
    }
}
