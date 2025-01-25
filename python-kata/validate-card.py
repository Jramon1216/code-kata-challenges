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