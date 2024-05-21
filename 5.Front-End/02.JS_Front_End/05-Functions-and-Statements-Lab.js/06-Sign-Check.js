function solve(number1, number2, number3) {
    let result = multiply(multiply(number1, number2), number3);
    
    let isPositive = result >= 0 ? 'Positive' : 'Negative';

    console.log(isPositive);    
    
    function multiply(a, b) {
        return a * b;
    }
}
 
solve(5, 12, -15);