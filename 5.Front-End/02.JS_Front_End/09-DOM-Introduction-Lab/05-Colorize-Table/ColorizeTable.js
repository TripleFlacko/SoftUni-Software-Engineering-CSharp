function colorize() {
    let elementsToColorize = document.querySelectorAll('table tr:nth-child(even)');

    for (const element of elementsToColorize) {
        element.style.backgroundColor = 'teal';
    }
}