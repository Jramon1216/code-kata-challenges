//Count IP Addresses - https://www.codewars.com/kata/526989a41034285187000de4
// Implement a function that receives two IPv4 addresses, and returns the number of addresses between them(including the first one, excluding the last one).
// All inputs will be valid IPv4 addresses in the form of strings.The last address will always be greater than the first one.

function ipsBetweenTS(start: string, end: string): number {
  const toDecimal = (ip: string) => {
    const octets: string[] = ip.split(".");
    let multiplier: number = 24;

    return octets.reduce((accu, octet) => {
      const num: number = parseInt(octet, 10) * 2 ** multiplier;
      multiplier -= 8;
      return accu + num;
    }, 0);
  };

  const ip1 = toDecimal(start);
  const ip2 = toDecimal(end);

  return ip2 - ip1;
}
