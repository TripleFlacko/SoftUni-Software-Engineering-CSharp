function solve(city) {
    let entries = Object.entries(city).forEach(kvp => console.log(`${kvp[0]} -> ${kvp[1]}`))
}
 
solve({
    name: "Sofia",
    area: 492,
    population: 1238438,
    country: "Bulgaria",
    postCode: "1000"
});