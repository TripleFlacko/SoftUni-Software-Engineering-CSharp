function solve(dayType, age) {
    let price;

    if (age < 0 || age > 122) {
        console.log("Error!");
        return;
    } else if (age <= 18) {
        if (dayType === "Weekday") {
            price = 12;
        } else if (dayType === "Weekend"){
            price = 15;
        } else {
            price = 5;
        }
    } else if (age <= 64) {
        if (dayType === "Weekday") {
            price = 18;
        } else if (dayType === "Weekend"){
            price = 20;
        } else {
            price = 12;
        }
    } else {
        if (dayType === "Weekday") {
            price = 12;
        } else if (dayType === "Weekend"){
            price = 15;
        } else {
            price = 10;
        }
    }
    console.log(price + "$")
}