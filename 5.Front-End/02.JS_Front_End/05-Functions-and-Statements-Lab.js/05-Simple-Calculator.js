function solve(number1, number2, mathAction) {
    let dictionary = {
        'multiply': (a, b) => a * b,
        'divide': (a, b) => a / b,
        'add': (a, b) => a + b,
        'subtract': (a, b) => a - b
    }

    console.log(dictionary[mathAction](number1, number2));
}
 
solve(5, 5, 'multiply');