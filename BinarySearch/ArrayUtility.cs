using System;

namespace BinarySearch
{
    static class ArrayUtility
    {
        public static int[] GetArrayFromInputElements() {
            int[] array = null;
            Console.WriteLine("Enter the number of elements for the array");
            try
            {
                int noOfElements = int.Parse(Console.ReadLine());
                array = new int[noOfElements];
                for (int i = 0; i < noOfElements; i++) {
                    Console.WriteLine("Enter element "+i);
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return array;
        }

        public static void BinarySearch(int[] array, int element) {

            int index = _BinarySearchUtil(array, 0, array.Length, element);
            if (index == -1)
            {
                Console.WriteLine("Entered element is not found in the array!");
            }
            else
            {
                Console.WriteLine("The element " + element + " is found at index " + index);
            }        
    }

    private static int _BinarySearchUtil(int[] array, int start, int end, int element) {

            while (start <= end) {
                int mid = (end + start) / 2;

                if (array[mid] == element) {
                    return mid;
                }

                if (array[mid] < element) {
                    return _BinarySearchUtil(array, mid+1, end, element);
                }

                if (array[mid] > element) {
                    return _BinarySearchUtil(array, start, mid-1, element);
                }
            }
            return -1;
        }

        public static bool isSortedArray(int[] array) {
            for (int i = 0; i< array.Length; i++){
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i] > array[j]) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
