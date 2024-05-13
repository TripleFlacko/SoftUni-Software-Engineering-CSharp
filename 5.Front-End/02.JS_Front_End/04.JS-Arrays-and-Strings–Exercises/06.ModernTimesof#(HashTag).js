function solve(text) {
    let words = text.matchAll(/#([a-zA-Z]+)/g);
    for (const word of words) {
        console.log(word[1]);
    }
}
 
solve('Nowadays everyone uses # to tag a #special word in #socialMedia');