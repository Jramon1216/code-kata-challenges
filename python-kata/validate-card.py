"""
Valitate Credit Card Number - https://www.codewars.com/kata/5418a1dd6d8216e18a0012b2

In this Kata, you will implement the Luhn Algorithm, which is used to help validate credit card numbers.

Given a positive integer of up to 16 digits, return true if it is a valid credit card number, and false if it is not.

Here is the algorithm:

    Double every other digit, scanning from right to left, starting from the second digit (from the right).

    Another way to think about it is: if there are an even number of digits, double every other digit starting with the first; if there are an odd number of digits, double every other digit starting with the second:
"""

def validate(n):
    # Convert integer to arra
    digits = [int(digit) for digit in str(n)]
    print(digits[::2])
    # Get length of array
    length = len(digits)
    # Check if array length is even or odd
    if length % 2 == 0:
    # Iterate through EVERY OTHER element in the array
        for i in digits[::2]:
    # Double the current value in the array
            if digits[i] * 2 > 9:
    # if the current value after doubling is GREATER THAN 9 subtract 9
                digits[i] = (digits[i] * 2) - 9
            else:
                digits[i] = digits[i] * 2 
        sum = sum(digits)
        return sum % 10 == 0
    else:
        for i in digits[::2]:
            if digits[i] * 2 > 9:
                digits[i] = (digits[i] * 2) - 9
            else:
                digits[i] = digits[i] * 2 
        sum = sum(digits)
        print(digits)
        return sum % 10 == 0



    # Get sum of values in array
    # return boolean depending on the sum when divided by ten is 0 or not


validate(123)