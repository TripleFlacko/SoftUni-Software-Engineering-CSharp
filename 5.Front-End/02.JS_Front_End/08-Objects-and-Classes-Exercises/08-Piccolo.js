function solve(input) {
    let parking = new Set();

    for (const command of input) {
        let [direction, licensePlate] = command.split(', ');

        if (direction === 'IN') {
            parking.add(licensePlate);
        } else {
            parking.delete(licensePlate);
        }
    }
    if (parking.size < 1) {
        console.log('Parking Lot is Empty');
    } else {
        Array.from(parking)
            .sort()
            .forEach(number => console.log(number));
    }
}

solve(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'OUT, CA1234TA']    
);