function solve (from, to) {
    let sum = 0;
    let digits = '';
    for (let i = from; i <= to; i++) {
        digits += `${i} `;
        sum += i;
    }

    console.log(digits.trim());
    console.log(`Sum: ${sum}`);
}