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