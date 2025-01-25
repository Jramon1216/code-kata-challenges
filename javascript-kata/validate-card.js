function validate(n) { // SOLUTION #1

    let arr = [...String(n)].map(Number), sum = 0;
    const len = arr.length;

    if (len % 2 === 0) {
        for (let index = 0; index < len; index++) {
            arr[index] = arr[index] * 2
            if (arr[index] > 9) arr[index] = arr[index] - 9;
            index++;
        }
        sum = arr.reduce((total, current) => total + current);
        return sum % 10 === 0;
    } else {
        for (let index = 1; index < len; index++) {
            arr[index] = arr[index] * 2
            if (arr[index] > 9) arr[index] = arr[index] - 9;
            index++;
        }
        sum = arr.reduce((total, current) => total + current);
        return sum % 10 === 0;
    }
}

// console.log(validate(1230)); 
// console.log(validate(123));  
// console.log(validate(1))
// console.log(validate(2121))
// console.log(validate(17893729974))

function validateTwo(n) { // SOLUTION #2
    let digits = [...String(n)].map(Number)

    if (digits.length % 2 === 0) {

        let modifiedDigits = digits.map((num, index) => {
            if(index % 2 === 0) {
                if ((num * 2) > 9){
                    return (num * 2) - 9; 
                } else {
                    return num * 2;
                }
            } else {
                return num 
            }
        }).reduce((total, current) => total + current);
        
        return modifiedDigits % 10 === 0;
        
    } else {
        
        let modifiedDigits = digits.map((num, index) => {
            let offsetIndex = index + 1;
            if (offsetIndex % 2 === 0) {
                if ((num * 2) > 9) {
                    return (num * 2) - 9;
                } else {
                    return num * 2;
                }
            } else {
                return num
            }

        }).reduce((total, current) => total + current);
        
        return modifiedDigits % 10 === 0;

    }

}
console.log(validateTwo(123))
console.log(validateTwo(1230))

/*
    Luhn's Algorithm

    1. Drop the check digit from the number (if it's already present). This leaves the payload.
    2. Start with the payload digits. Moving from right to left, double every second digit, starting from the last digit. If doubling a digit results in a value > 9, subtract 9 from it (or sum its digits).
    3. Sum all the resulting digits (including the ones that were not doubled).
    4. The check digit is calculated by ( 10 − ( s mod 10 ) ) mod 10 where s is the sum from step 3. 
        This is the smallest number (possibly zero) that must be added to s to make a multiple of 10. 
        Other valid formulas giving the same value are 9 − ( ( s + 9 ) mod 10), ( 10 − s ) mod 10 and 10 ⌈ s / 10 ⌉ − s. 
        Note that the formula ( 10 − s ) mod 10  will not work in all environments due to differences in how negative numbers are handled by the modulo operation.

*/