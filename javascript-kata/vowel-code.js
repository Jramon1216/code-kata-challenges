function encode(string) {
    const dict = {
        'a': '1',
        'e': '2',
        'i': '3',
        'o': '4',
        'u': '5'
    };

    let arr = string.split('');

    for (let i = 0; i < arr.length; i++) {
        let elm = arr[i];
        if (dict.hasOwnProperty(elm)) {
            arr[i] = dict[elm];
        }

    }

    return arr.join('');
}


console.log(encode('hello how are you today?'));


function decode(string) {
    const dict = {
        '1': 'a',
        '2': 'e',
        '3': 'i',
        '4': 'o',
        '5': 'u'

    }

    let arr = string.split('');

    for (let i = 0; i < arr.length; i++) {
        let elm = arr[i];
        if (dict.hasOwnProperty(elm)) {
            arr[i] = dict[elm];
        }

    }
    return arr.join('');

}

console.log(decode(encode('hello how are you today?')));