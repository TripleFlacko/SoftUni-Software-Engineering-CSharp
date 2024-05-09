function solve(arrayOfStrings, nth) {
    let tempArray = [];

    for (let index = 0; index < arrayOfStrings.length; index += nth) {
        tempArray.push(arrayOfStrings[index]);
    }

    return tempArray;
}
 
solve(['5', '20','31', '4', '20'], 2);