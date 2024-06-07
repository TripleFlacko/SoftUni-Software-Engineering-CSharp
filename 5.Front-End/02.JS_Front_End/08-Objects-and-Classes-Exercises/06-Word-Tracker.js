function solve(input) {
    let result = {};
    let words = input.shift().split(' ');

    words.forEach(word => result[word] = 0);

    for (let i = 0; i < words.length; i++) {
        for (let j = 0; j < input.length; j++) {
                 if (words[i] === input[j]) {
                    result[words[i]]++;
                 }   
        }        
    }

    result = Object.entries(result).sort((a, b) => b[1] - a[1]);

    for (const kvp of result) {
        console.log(`${kvp[0]} - ${kvp[1]}`);
    }
}
 
solve([
    'this sentence', 
    'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurrences', 'of', 'the', 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task'
    ]
    );