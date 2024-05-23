function solve(password) {
    let isValid = true;

    if (password.length < 6 || password.length > 10) {
        isValid = false;
        console.log('Password must be between 6 and 10 characters');
    }

    if (!(/^[a-zA-Z0-9]+$/.test(password))) {
        isValid = false;
        console.log('Password must consist only of letters and digits');
    }

    if (checkTwoDigits(password)) {
        isValid = false;
        console.log('Password must have at least 2 digits');
    }

    if (isValid) {
        console.log('Password is valid');
    }

    function checkTwoDigits(password) {
        let arrayOfDigits = password
        .split('')
        .filter(character => /^\d+$/.test(character));

        return arrayOfDigits.length >= 2 ? false : true;
    }
}
 
// solve('logIn');
// solve('MyPass123');
solve('Pa$s$s');