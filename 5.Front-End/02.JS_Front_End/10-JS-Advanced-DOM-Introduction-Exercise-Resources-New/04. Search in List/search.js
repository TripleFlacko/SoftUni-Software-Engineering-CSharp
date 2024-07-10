function search() {
   let towns = document.querySelectorAll('#towns li');
   const searchText = document.getElementById('searchText').value.toLowerCase();
   let result = document.getElementById('result');

   towns.forEach(element => {
         element.style.textDecoration = 'none';
         element.style.fontWeight = '400';
   });

   let matches = 0;

   towns.forEach(element => {
      let city = element.textContent.toLowerCase();

      if (city.includes(searchText)) {
         element.style.textDecoration = 'underline';
         element.style.fontWeight = 'bold';
         matches++;
      }
   });

   result.textContent = `${matches} matches found`
}
