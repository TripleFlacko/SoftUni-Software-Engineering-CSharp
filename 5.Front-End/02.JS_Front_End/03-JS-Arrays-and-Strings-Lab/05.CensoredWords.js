function solve(text, censoredWord){
    text = text.replace(new RegExp(censoredWord, 'g'), '*'.repeat(censoredWord.length));
    
    console.log(text);
}

solve('Find the hidden word', 'hidden');