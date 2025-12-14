using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace c_sharp_kata.Solutions;

/*
Create Phone Number - https://www.codewars.com/kata/525f50e3b73515a6db000b83

Write a function that accepts an array of 10 integers (between 0 and 9), 
that returns a string of those numbers in the form of a phone number.

Example
Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"

*/

//TODO
// - Create a for loop to iterate through the list
// - Get the length of the result string to know when/where to put "special character"


public class CreatePhoneNumberSolution
{
    // * long solution using a loop
    public static string CreatePhoneNumber(int[] numbers)
    {
        string phoneNumber = "(";
        int counter;

        foreach (int number in numbers)
        {
            counter = phoneNumber.Length;
            if (counter == 4) phoneNumber += ") ";
            if (counter == 9) phoneNumber += '-';
            phoneNumber += number;
        }

        return phoneNumber;
    }

    // * Solution using slicing and string.Join method
    public static string CreatePhoneNumber2(int[] numbers)
    {
        return $"({string.Join("",numbers[0..3])}) {string.Join("",numbers[3..6])}-{string.Join("",numbers[6..])}";
    }
}