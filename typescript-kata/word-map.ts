// This challenge was asked in a job application

// Write a function that takes a string and returns an object mapping each word to the number of times it appears. The function should be case-insensitive and ignore punctuation.

const sentence: string = "The Cat And the dog and the bird.";

function occurences(sentence: string) {
  let wordMap: Map<string, number> = new Map<string, number>();

  const arr: string[] = sentence
    .toLowerCase()
    .replace(/[!"#$%&'()*+,-./:;<=>?@[\]^_`{|}~]/g, "")
    .split(" ");

  for (let index = 0; index < arr.length; index++) {

    const word = arr[index];
    const count = (wordMap.get(word) ?? 0) + 1;
    wordMap.set(word, count);

    }

    return wordMap;
}

console.log(occurences(sentence));
