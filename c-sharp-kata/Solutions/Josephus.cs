namespace c_sharp_kata.Solutions;

/**
 * Josephus Permutation - https://www.codewars.com/kata/5550d638a99ddb113e0000a2
 * create a function that returns a Josephus permutation, taking as parameters the initial array/list of items to be permuted as if they were in a circle and counted out every k places until none remained.
 */

public class Josephus
{
    public static List<object> JosephusPermutation(List<object> items, int k)
    {
        int len = items.Count;
        int pointer = 0;
        
        List<object> res = [];
        
        while (len > 1)
        {
        // iterate unil k-1 then add current element to res
        // if pointer == length of list then reset to 0
        // maybe another condition where if the element is in res then skip it and remove the next?
        // avoid O(n²) solution using list methods
        
        }
        return [];
    }
}
