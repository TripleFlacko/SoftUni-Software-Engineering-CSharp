function solve(number1, number2) {

    let factorial1 = calculateFactorial(number1);  
    let factorial2 = calculateFactorial(number2);

    console.log((factorial1 / factorial2).toFixed(2));
    
    function calculateFactorial(number) {

        if (number === 0) {
            return 1;            
        }

        return number * calculateFactorial(number - 1);
    }
}
 
solve(5, 2);
solve(6, 2);