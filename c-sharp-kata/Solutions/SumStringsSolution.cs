using System.Numerics;

namespace c_sharp_kata.Solutions;
/*
    Sum Strings as Numbers - https://www.codewars.com/kata/5324945e2ece5e1f32000370
    Given the string representations of two integers, return the string representation of the sum of those integers.

    For example:

    sumStrings('1','2') // => '3'

    A string representation of an integer will contain no characters besides the ten numerals "0" to "9".
*/

public class SumStringsSolution
{
    public static string SumStrings(string a, string b) 
    // long soultion without using TryParse
    {

        bool aIsNeg = a.Contains('-'),
             bIsNeg = b.Contains('-');

        BigInteger numA = 0;
        BigInteger numB = 0;

        foreach (var character in a) // convert by character
        {
            if (character == '-') continue;

            numA = numA * 10 + Int32.Parse(character.ToString());
        }

        foreach (var character in b)
        {
            if (character == '-') continue;

            numB = numB * 10 + Int32.Parse(character.ToString());
        }

        numA = aIsNeg ? -numA : numA;
        numB = bIsNeg ? -numB : numB;

        string res = $"{numA + numB}";

        return res;
    }
} 