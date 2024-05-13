function solve(names) {
    names.sort((a, b) => a.toLowerCase().localeCompare(b.toLowerCase()));
    for (let index = 0; index < names.length; index++) {
        console.log(`${index + 1}.${names[index]}`)
    }
}
 
solve(["John", "Bob", "Christina", "Ema"]);