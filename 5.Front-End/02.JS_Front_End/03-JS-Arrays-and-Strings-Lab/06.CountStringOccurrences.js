function solve(text, wordToCount){
    let array = text.split(' ');
    let count = 0;
    for(word of array){
        if(word == wordToCount){
            count++;
        }
    }
    console.log(count)
}

solve('This is a word and it also is a sentence', 'is');