function extract(content) {
    let extractedText = document
    .getElementById(content)
    .textContent
    .matchAll(/\(([a-zA-Z\s]+)\)/g);

    let array = Array
    .from(extractedText)
    .map(element => element[1]);

    return array.join('; ');
}