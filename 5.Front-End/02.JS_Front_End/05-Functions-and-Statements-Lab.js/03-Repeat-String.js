function solve(text, number) {
    let result = '';
    for (let index = 0; index < number; index++) {
        result += text;
    }
    console.log(result);
}
 
solve('abc', 3);