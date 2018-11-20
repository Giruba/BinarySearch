# BinarySearch
C# program for finding an element in an array using Binary Search


Additional Logic: Checks whether the input array is actually sorted before searching for the element.
This is because, 'Binary Search' works for only sorted arrays.


Logic - BinarySearch(array, start, end)
---------------------------------------
1. While start<=end, do the following
  1.a  Calculate mid as start+end/2;
  1.b If array[mid] == element, return mid as the index where the element was found.
  1.c If array[mid] < element, this means middle element is less than entered element.
      So, we should search to the right of the middle element
      So recur BinarySearch(array, mid+1, end)
  1.d If array[mid] > element, then middle element is greater than the entered element
      So, we should search left of middle element 
      So recur BinarySearch(array, start, mid-1)
      
      
      
 2. If th search is unfruitful, return -1

