function solve(arrayOfNumbers) {

    checkIfPalindrome(arrayOfNumbers).forEach(value => console.log(value));
    
    function checkIfPalindrome(numbers) {        
        let result = [];

        for (const number of numbers) {

            let reversedString = String(number)
            .slice()
            .split('')
            .reverse()
            .join('');

            let forward = number;
            let backward = Number(reversedString);

            result.push(forward === backward ? true : false);
        }

        return result;
    }
}

solve([123, 323, 421, 121]);