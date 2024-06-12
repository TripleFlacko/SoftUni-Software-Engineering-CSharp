function extractText() {
    let items = document.querySelectorAll('#items li');
    let textArea = document.querySelector('#result');

    for (const item of items) {
        textArea.textContent += item.textContent + '\n';
    }
}