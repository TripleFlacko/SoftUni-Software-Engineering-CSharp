function solve(number) {
    let string = number.toString();
    let previousDigit = '';
    let same = true;
    let sum = 0;

    for (i = 1; i < string.length; i++){
        previousDigit = string[i - 1];

        if (previousDigit !== string[i]) {
            same = false;
        }

        sum += Number(string[i]);
    }

    sum += Number(string[0]);
    console.log(same);
    console.log(sum);
}