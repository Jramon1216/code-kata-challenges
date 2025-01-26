/* 
    Two Sum - https://www.codewars.com/kata/52c31f8e6605bcc646000082

    Write a function that takes an array of numbers (integers for the tests) and a target number. It should find two different items in the array that, when added together, give the target value. The indices of these items should then be returned in a tuple / list (depending on your language) like so: (index1, index2).

    For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

    The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).
*/


function twoSum(numbers, target) {
    for (let i = 0; i < numbers.length; i++) {
        for (let n = i + 1; n < numbers.length; n++) {
            if (numbers[i] + numbers[n] === target) {
                return [i, n]
            }
        }
    }
}

function twoSum(numbers, target) {
    const arr = numbers.sort((a, b) => a - b);
    console.log(arr)

    let left = 0, right = arr.length - 1;

    while (left < right) {
        let sum = arr[left] + arr[right];


        if (sum === target) {
            return [left, right];
        } else if (sum < target) {
            left++;
        } else {
            right--;
        }
    }
}

console.log(twoSum([2, 3, 1], 3))