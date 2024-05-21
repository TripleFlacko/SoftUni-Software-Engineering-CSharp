function solve(numArray){
    let result = 0;
    for(let i = 0; i < numArray.length; i++){
            if(numArray[i] % 2 == 0){
                result += numArray[i];
                } else {
                    result -= numArray[i];
                }
        }

    console.log(result);
}

solve([1,2,3,4,5,6]);