function solve(input) {
    let addressBook = {};

    for (const line of input) {
        let [person, address] = line.split(':');
        
        addressBook[person] = address;
    }

    sortedArray = Object.entries(addressBook).sort((a, b) => a[0].localeCompare(b[0]));
    addressBook = Object.fromEntries(sortedArray);

    for (const person in addressBook) {
        console.log(`${person} -> ${addressBook[person]}`);        
    }
}
 
solve(['Tim:Doe Crossing',
'Bill:Nelson Place',
'Peter:Carlyle Ave',
'Bill:Ornery Rd']);