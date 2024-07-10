function solve() {
  let text = document.getElementById('text').value.toLowerCase().split(' ');
  const namingConvention = document.getElementById('naming-convention').value;
  const resultElement = document.getElementById('result');

  if (namingConvention == 'Camel Case'){

    text = text.map(word => capitalize(word)).join('');

    text = text[0].toLowerCase() + text.slice(1);

  } else if (namingConvention == 'Pascal Case') {

   text = text.map(word => capitalize(word)).join('');

  } else {

    text = 'Error!';
    
  }

  resultElement.textContent = text;

  function capitalize(word){
    return word.charAt(0).toUpperCase() + word.slice(1);
  }
}