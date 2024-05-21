function solve(numbers) {
    numbers.sort((a, b) => a - b);
    let finalArray = [];
    for (let index = 0; index < numbers.length;) {
        finalArray.push(numbers.shift());
        finalArray.push(numbers.pop());
    }

    return finalArray;
}
 
solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);