function sumTable() {
    let productPrices = document.querySelectorAll('tr:not(:last-child) td:last-child');

    let total = Array
    .from(productPrices)
    .reduce((sum, price) => sum + Number(price.textContent), 0);

    document.getElementById('sum').textContent = total;
}