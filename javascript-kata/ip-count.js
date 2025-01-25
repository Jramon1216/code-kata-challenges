// Implement a function that receives two IPv4 addresses, and returns the number of addresses between them(including the first one, excluding the last one).
// All inputs will be valid IPv4 addresses in the form of strings.The last address will always be greater than the first one.



function ipsBetween(start, end) {
    let multiplierA = 24, multiplierB = 24;

    const ip1 = start.split(".").map(num => {
        parseInt(num, 10)
        num = num * (2 ** multiplierA);
        multiplierA = multiplierA - 8;
        return num
    }).reduce((accu, curr) => accu += curr);

    const ip2 = end.split(".").map(num => {
        parseInt(num, 10)

        num = num * (2 ** multiplierB);
        multiplierB = multiplierB - 8;
        return num
    }).reduce((accu, curr) => accu += curr, 0)


    return ip2 - ip1
}


function ipsBetween2(start, end) { // Rather than repeat calculations use a function that does all the work!
    const toDecimal = (ip) => { 
        const octets = ip.split("."); // Split into octets
        let multipler = 24; 
        
        return octets.reduce((accu, octet) => { // convert each octet into an integer and then caluclate the sum of all octets
            const num = parseInt(octet, 10) * (2 ** multipler);
            multipler -= 8;
            return accu + num 
        }, 0)
    }

    const ip1 = toDecimal(start), ip2 = toDecimal(end);
    
    return ip2 - ip1
}


console.log(ipsBetween("150.0.0.0", "150.0.0.1"));
// console.log(ipsBetween("10.0.0.0", "10.0.0.50"));
// console.log(ipsBetween("20.0.0.10", "20.0.1.0"));
// console.log(ipsBetween("10.11.12.13", "10.11.13.0"));
// console.log(ipsBetween("160.0.0.0", "160.0.1.0"));
// console.log(ipsBetween("170.0.0.0", "170.1.0.0"));
// console.log(ipsBetween("50.0.0.0", "50.1.1.1"));
// console.log(ipsBetween("180.0.0.0", "181.0.0.0"));
// console.log(ipsBetween("1.2.3.4", "5.6.7.8"));
// console.log(ipsBetween("0.0.0.0", "255.255.255.255"));
