function solve(number) {
    let sumOfDivisors = findDivisors(number).reduce((sum, divisor) => sum + divisor, 0);

    console.log(number === sumOfDivisors ? 'We have a perfect number!' : 'It\'s not so perfect.');

    function findDivisors(number) {
        let divisors = [];

        for (let index = 1; index < number; index++) {
            if (number % index == 0) {
                divisors.push(index);
            }            
        }

        return divisors;
    }     
}
 
solve(6);
solve(28);
solve(1236498);