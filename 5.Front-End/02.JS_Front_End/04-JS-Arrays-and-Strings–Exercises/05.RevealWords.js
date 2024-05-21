function solve(words, text) {
    let revealWords = words.split(', ');
    text = text.split(' ');

    text.forEach((word, index) => {
        for (const revealWord of revealWords) {
            if (word === '*'.repeat(revealWord.length)) {
                text[index] = revealWord;
            }
        }
    });

    console.log(text.join(' '));
}
 
solve('great, learning', 'softuni is ***** place for ******** new programming languages');