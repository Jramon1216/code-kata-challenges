function goodVsEvil(good, evil) {
    const battleResults = {
        good: "Battle Result: Good triumphs over Evil",
        evil: "Battle Result: Evil eradicates all trace of Good",
        tie: "Battle Result: No victor on this battle field"
    }


    const goodWorth = [1, 2, 3, 3, 4, 10], evilWorth = [1, 2, 2, 2, 3, 5, 10]

    const totalGoodWorth = good.split(' ').map(n => parseInt(n, 10)).reduce((sum, count, index) => sum + count * goodWorth[index], 0);
    const totalEvilWorth = evil.split(' ').map(n => parseInt(n, 10)).reduce((sum, count, index) => sum + count * evilWorth[index], 0);

    if (totalGoodWorth > totalEvilWorth) {
        return "Battle Result: Good triumphs over Evil";
    }
    else if (totalGoodWorth < totalEvilWorth) {
        return "Battle Result: Evil eradicates all trace of Good";
    }
    else {
        return "Battle Result: No victor on this battle field"
    }

}



console.log(goodVsEvil('0 0 0 0 0 10', '0 1 1 1 1 0 0'));