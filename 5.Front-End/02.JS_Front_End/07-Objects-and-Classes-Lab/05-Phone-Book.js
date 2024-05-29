function solve(info) {
    let phoneBook = {};

    for (let person of info) {
        let [name, phone] = person.split(' ');  

        phoneBook[name] = phone;
    }

    Object.entries(phoneBook).forEach(person => console.log(`${person[0]} -> ${person[1]}`))
}
 
solve(['Tim 0834212554',
'Peter 0877547887',
'Bill 0896543112',
'Tim 0876566344']);