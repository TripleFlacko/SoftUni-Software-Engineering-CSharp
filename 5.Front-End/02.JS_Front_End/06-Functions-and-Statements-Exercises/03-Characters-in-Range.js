function solve(...chars) {
    chars = chars.sort();

    let start = chars[0].charCodeAt(0);
    let end = chars[1].charCodeAt(0);

    let charsFromRange = findCharsInRange(start, end).join(' ');

    console.log(charsFromRange);

    function findCharsInRange(start, end) {        
        let foundChars = [];

        for (let index = start + 1; index < end; index++) {
            foundChars.push(String.fromCharCode(index));            
        }

        return foundChars;
    }
}

solve('a', 'd');