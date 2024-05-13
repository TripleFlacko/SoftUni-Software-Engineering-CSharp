function solve(word, text) {
    let tempArray = text.split(' ');
    let wasFound = false;

    for (const iterator of tempArray) {
        if (iterator.toLowerCase() == word) {
            console.log(word);  
            wasFound = true;          
        }
    }

    if (!wasFound) {
        console.log(`${word} not found!`)        
    }
}
 
solve('javascript', 'JavaScript is the best programming language');