namespace c_sharp_kata.Solutions;

public class ArrayDiff
{
    public static int[] performDiff(int[] a, int[] b)
    {
    //TODO: Implement O(n) solution using LINQ

    /*
      Array.diff - https://www.codewars.com/kata/523f5d21c841566fde000009/
      
      Implement a function that computes the difference between two lists. 
      The function should remove all occurrences of elements from the first list (a) that are present in the second list (b). 
      The order of elements in the first list should be preserved in the result. 
    */


    /*
    iterate through b array
    if a array contains current b array value then RemoveAll() - O(n²)
   */

    List<int> first = new List<int>(a);
    
    for (int i=0; i < b.Length; i++)
    {
      if(first.Contains(b[i]))
      {
        first.RemoveAll(num => num == b[i]);
      }      
    }
  
    int[] res = first.ToArray();
    return res;
  }

}