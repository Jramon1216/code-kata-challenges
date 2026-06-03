namespace c_sharp_kata.Solutions;

using System.Collections.Generic;
using System.Linq;

/*
Your order, please - https://www.codewars.com/kata/55c45be3b2079eccff00010f

Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
Examples

"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
""  -->  ""

*/
public class OrderPleaseSolution
{
    public static string Order(string words)
    // * Brute force O(n^2) solution

    {
        if (String.IsNullOrEmpty(words)) return words;

        List<string> wordList = [..words.Split(" ")];

        Dictionary<int, string> pos = [];
 
        foreach (string word in wordList)
        {
            foreach (char letter in word)
            {
                if (int.TryParse(letter.ToString(), out int num))
                {
                    pos.Add(num, word);
                }
            }
        }

        // ? Try using a map and ordering it to get the final output
        var res = string.Join(" ", pos.OrderBy(data => data.Key).Select(data => data.Value).ToArray());


        return res;
    }
}