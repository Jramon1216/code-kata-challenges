/* 
    https://www.codewars.com/kata/515decfd9dcfc23bb6000006/
    
    Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.

    Valid:
        4 octets 
        Numbers between zero and 255(inclusive)

    Invalid
        Less than 4 octets
        Numbers with Leading Zeros
        Letters
        Symbols (Excluding the '.' that seperates the octets of course) 
        WhiteSpace
*/

// This problem was written in typescript and then compiled into javascript-kata/ip-validator.js

function isValidIP(str: string) {
    let array: string[] = str.split('.'); // Seperate the string into an array
    
    if (
      array.length < 4 ||
      array.length > 4 ||
      str.match(/\s/g) ||
      str.match(/[a-zA-Z]/)
    )
      return false; // Handle number octets and any whitespace characters
    
    for (let index = 0; index < array.length; index++) {
        let octet: string | number = array[index]; // Give octet a union type for both string and integer validation
        
        if (octet.match(/[!@#$%^&*()]/) || (octet.length > 1 && octet.startsWith('0')) || octet === '') return false; // Handle letters, symbols, and leading zeros or any leftover empty strings
        
        octet  = parseInt(octet); // Since the octet has passed string validation by this point, convert it to an integer and check its value 
        
        if (octet < 0 || octet > 255) return false
    }

    return true
}


