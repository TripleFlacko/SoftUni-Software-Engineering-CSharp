function solve(percentage) {
    console.log(generateLoadingBar(percentage));
    console.log(percentage < 100 ? 'Still loading...' : 'Complete!');

    function generateLoadingBar(percentage) {
        let progressBar = `${percentage}% [${'%'.repeat(percentage / 10)}${'.'.repeat(10 - percentage / 10)}]`

        return progressBar;
    }
}
 
solve(30);
solve(50);
solve(100);