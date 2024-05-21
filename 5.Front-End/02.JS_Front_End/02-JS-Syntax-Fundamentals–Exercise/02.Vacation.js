function solve (people, groupType, day) {
    let price = 0;
    if (groupType === 'Students') {
        switch (day) {
            case 'Friday':
                price = 8.45;
                break;
            case 'Saturday':
                price = 9.80;
                break;
            case 'Sunday':
                price = 10.46;
                break;
        }
    } else if (groupType === 'Business'){
        switch (day) {
            case 'Friday':
                price = 10.90;
                break;
            case 'Saturday':
                price = 15.60;
                break;
            case 'Sunday':
                price = 16;
                break;
        }
    } else if (groupType === 'Regular') {
        switch (day) {
            case 'Friday':
                price = 15;
                break;
            case 'Saturday':
                price = 20;
                break;
            case 'Sunday':
                price = 22.50;
                break;
        }
    }

    let totalPrice = people * price;

    if (groupType === 'Students' && people >= 30) {
        totalPrice *= 0.85;
    } else if (groupType === 'Business' && people >= 100) {
        totalPrice = (people - 10) * price;
    } else if (groupType === 'Regular' && people >= 10 && people <= 20) {
        totalPrice *= 0.95;
    }

    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}

solve(30, "Students", "Sunday");