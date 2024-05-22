function solve(first, second, third) {
    let result = findSmallest(findSmallest(first, second), third);
    
    console.log(result);

    function findSmallest(a, b) {
        return a < b ? a : b;
    }    
}

solve(2, 5, 3);