function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let text = document.getElementById('searchField');

      let rows = document.querySelectorAll('.container tbody tr');

      rows.forEach(row => {
         row.classList.remove('select');
      })
      
      rows.forEach(row => {
         const cells = row.children;
         
         for (const cell of cells) {
            const toFind = text.value.toLowerCase();
            const toCheck = cell.textContent.toLocaleLowerCase();

            if (toCheck.includes(toFind)) {
               row.classList.add('select');
            }
         }   
      });
   }
}