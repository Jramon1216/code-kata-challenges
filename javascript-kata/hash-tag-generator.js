//  The Hashtag Generator - https://www.codewars.com/kata/52449b062fb80683ec000024
//  The marketing team is spending way too much time typing in hashtags.
//  Let's help them with our own Hashtag Generator!

// Here's the deal:

//     It must start with a hashtag(#).
//     All words must have their first letter capitalized.
//     If the final result is longer than 140 chars it must return false.
//     If the input or the result is an empty string it must return false.

function generateHashtag(str) {

    const hashTag = str.charAt(0) === "#" ? str.trim().split(/\s+/).map(word => String(word).charAt(0).toUpperCase() + String(word).slice(1)).join('') : "#" + str.trim().split(/\s+/).map(word => String(word).charAt(0).toUpperCase() + String(word).slice(1)).join('');

    return hashTag.length > 140 || hashTag.length === 1 ? false : hashTag
}

console.log(generateHashtag("#Apricot"))
console.log(generateHashtag(""))
console.log(generateHashtag(" ".repeat(140)));
console.log(generateHashtag("code" + " ".repeat(140) + "wars"));
console.log(generateHashtag("  big yikes  "))
console.log(generateHashtag("Looooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooong Cat"))


