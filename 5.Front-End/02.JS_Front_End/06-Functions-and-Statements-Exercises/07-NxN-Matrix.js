function solve(number) {
    for (let index = 0; index < number; index++) {
        console.log(generateRow(number));
    }

    function generateRow(length) {
        let row = Array(number)
        .fill(number)
        .join(' ');

        return row;
    }     
}
 
solve(3);
solve(2);
solve(7);
solve(10);