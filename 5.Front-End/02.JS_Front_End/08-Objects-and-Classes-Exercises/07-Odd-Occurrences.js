function solve(input) {
    const words = input.toLowerCase().split(' ');
    const countedWords = {};

    for (let word of words) {
        countedWords[word] = (countedWords[word] || 0) + 1;
    }

    const result = Object.keys(countedWords).filter(word => countedWords[word] % 2 !== 0);

    console.log(result.join(' '));
}

 
solve('Java C# Php PHP Java PhP 3 C# 3 1 5 C#');