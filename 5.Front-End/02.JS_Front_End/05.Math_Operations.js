function solve(firstNum, secondNum, operator) {
    let result;
    switch (operator) {
        case '+':
            result = firstNum + secondNum;
            break;
        case '-':
            result = firstNum - secondNum;
            break;
        case '/':
            result = firstNum / secondNum;
            break;
        case '*':
            result = firstNum * secondNum;
            break;
        case '%':
            result = firstNum % secondNum;
            break;
        case '**':
            result = firstNum ** secondNum;
            break;
    }
    console.log(result)
}