function solve(input) {
    let towns = input.map(row => {
        let [town, latitude, longitude] = row.split(' | ');

        return {
            town,
            latitude: Number(latitude).toFixed(2),
            longitude: Number(longitude).toFixed(2)
        }
    })

    towns.forEach(town => console.log(town))
}

solve(['Sofia | 42.696552 | 23.32601',
'Beijing | 39.913818 | 116.363625']);