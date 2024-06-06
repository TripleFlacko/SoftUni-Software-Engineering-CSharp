function solve(input) {
    let list = {};

    input.forEach(name => list[name] = name.length);

    for (const name in list) {
        console.log(`Name: ${name} -- Personal Number: ${list[name]}`);
    }
}
 
solve([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
]);