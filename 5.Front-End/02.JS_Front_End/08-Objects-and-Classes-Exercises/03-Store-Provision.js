function solve(...input) {
    let products = {};

    for (let i = 0; i < input.length; i++) {
        for (let j = 0; j < input[i].length; j += 2) {
            let product = input[i][j];
            let quantity = Number(input[i][j + 1]);

            if (products.hasOwnProperty(product)) {
                products[product] += quantity;            
            } else {
                products[product] = quantity;
            }
        }
    }

    Object.entries(products)
    .forEach(([product, quantity]) => console.log(`${product} -> ${quantity}`));
}
 
solve(
    ["Chips", "5", "CocaCola", "9", "Bananas", "14", "Pasta", "4", "Beer", "2"],
    ["Flour", "44", "Oil", "12", "Pasta", "7", "Tomatoes", "70", "Bananas", "30"]
);