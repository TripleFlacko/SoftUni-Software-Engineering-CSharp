function solve(input) {
    let parsedObject = JSON.parse(input);
    Object.entries(parsedObject).forEach(kvp => console.log(`${kvp[0]}: ${kvp[1]}`));
}
 
solve('{"name": "George", "age": 40, "town": "Sofia"}');