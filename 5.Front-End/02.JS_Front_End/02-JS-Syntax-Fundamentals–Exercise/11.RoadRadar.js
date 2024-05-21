function solve(speed, area) {
    let speedLimit = 0;
    let status = '';

    switch(area) {
        case 'motorway':
            speedLimit = 130;
            break;
        case 'interstate':
            speedLimit = 90;
            break;
        case 'city':
            speedLimit = 50;
            break;
        case 'residential':
            speedLimit = 20;
            break;
    }

    let diff = speed - speedLimit;

    if(diff <= 20) {
        status = 'speeding';
    } else if(diff <= 40){
        status = 'excessive speeding';
    } else if(diff > 40) {
        status = 'reckless driving';
    }

    if(speed <= speedLimit) {
        console.log(`Driving ${speed} km/h in a ${speedLimit} zone`);
    } else {
        console.log(`The speed is ${diff} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
    }
}