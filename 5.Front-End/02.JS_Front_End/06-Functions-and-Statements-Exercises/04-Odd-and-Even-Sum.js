function solve(number) {
    let numberToString = String(number).split('').map(Number);

    let evenSum = 0;
    let oddSum = 0;

    for (let digit of numberToString) {
        if (digit % 2 === 0) {
            evenSum += digit;
        } else {
            oddSum += digit;
        }
    }

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}

solve(1000435);