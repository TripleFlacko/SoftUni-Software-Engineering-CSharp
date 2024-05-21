function solve(numbers, number) {
    for (let i = 0; i < number; i++) {
        let tempNumber = numbers.shift();
        numbers.push(tempNumber);        
    }
    console.log(numbers.join(' '))
}

solve([51, 47, 32, 61, 21], 2);