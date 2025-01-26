/**
    Array Helpers - https://www.codewars.com/kata/525d50d2037b7acd6e000534     

    This kata is designed to test your ability to extend the functionality of built-in classes. In this case, we want you to extend the built-in Array class with the following methods: square(), cube(), average(), sum(), even() and odd().

    Explanation:

    * square() must return a copy of the array, containing all values squared

    * cube() must return a copy of the array, containing all values cubed
    
    * average() must return the average of all array values; on an empty array must return NaN; 
    
    * sum() must return the sum of all array values
    
    * even() must return an array of all even numbers
    
    * odd() must return an array of all odd numbers

 */



Array.prototype.square = function () {
    return this.map(val => val ** 2);
}

Array.prototype.cube = function () {
    return this.map(val => val ** 3);
}

Array.prototype.average = function () {
    if (!this) return NaN

    return (this.sum() / this.length)
}

Array.prototype.sum = function () {
    return this.reduce((accu, curr) => accu + curr, 0)
}

Array.prototype.even = function () {
    return this.filter(val => val % 2 == 0)
}

Array.prototype.odd = function () {
    return this.filter(val => val % 2 != 0)
}




let numbers = [1, 2, 3, 4, 5]

console.log(numbers.square())
console.log(numbers.cube())
console.log(numbers.sum())
console.log(numbers.average())
console.log(numbers.even())
console.log(numbers.odd())