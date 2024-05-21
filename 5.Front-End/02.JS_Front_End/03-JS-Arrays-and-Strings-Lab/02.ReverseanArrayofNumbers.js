function solve(number, array){
    let selection = array.splice(0, number).reverse();
    console.log(selection.join(' '));
}

solve(3, [10, 20, 30, 40, 50]);