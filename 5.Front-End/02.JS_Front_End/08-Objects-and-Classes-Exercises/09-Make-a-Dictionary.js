function solve(input) {
    let dictionary = {};

    for (const word of input) {
        let parsedData = JSON.parse(word);
        dictionary[Object.keys(parsedData)[0]] = Object.values(parsedData)[0];
    }

    let sortedDictionary = Object.entries(dictionary).sort();

    sortedDictionary.forEach(word => console.log(`Term: ${word[0]} => Definition: ${word[1]}`))
}

solve([
    '{"Cup":"A small bowl-shaped container for drinking from, typically having a handle"}',
    '{"Cake":"An item of soft sweet food made from a mixture of flour, fat, eggs, sugar, and other ingredients, baked and sometimes iced or decorated."} ',
    '{"Watermelon":"The large fruit of a plant of the gourd family, with smooth green skin, red pulp, and watery juice."} ',
    '{"Music":"Vocal or instrumental sounds (or both) combined in such a way as to produce beauty of form, harmony, and expression of emotion."} ',
    '{"Art":"The expression or application of human creative skill and imagination, typically in a visual form such as painting or sculpture, producing works to be appreciated primarily for their beauty or emotional power."} '
]
);