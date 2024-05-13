function solve(text) {
    let matches = text.matchAll(/[A-Z][a-z]*/g);
    let result = Array.from(matches).map(match => match[0]).join(', ');
    console.log(result);
}
 
solve('SplitMeIfYouCanHaHaYouCantOrYouCan');