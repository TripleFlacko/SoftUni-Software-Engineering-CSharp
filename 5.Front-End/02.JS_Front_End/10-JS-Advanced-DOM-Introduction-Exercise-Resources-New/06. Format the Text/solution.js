function solve() {
  const text = document.getElementById('input').value.trim();
  const output = document.getElementById('output');

  output.innerHTML = '';

  const sentences = text
    .split('.')
    .map(sentence => sentence.trim())
    .filter(sentence => sentence.length > 0);

  for (let i = 0; i < sentences.length; i += 3) {
    const paragraph = sentences.slice(i, i + 3).join('. ') + '.';
    const element = document.createElement('p');
    element.textContent = paragraph;
    output.append(element);
  }
}