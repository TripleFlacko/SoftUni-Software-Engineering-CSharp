function solve(meetings) {
    let schedule = {};

    for (let meeting of meetings) {
        let [day, name] = meeting.split(' ');

        if(schedule[day]) {
            console.log(`Conflict on ${day}!`);
        } else {
            schedule[day] = name;
            console.log(`Scheduled for ${day}`);
        }
    }

    Object.entries(schedule).forEach(kvp => console.log(`${kvp[0]} -> ${kvp[1]}`))
}
 
solve(['Friday Bob',
'Saturday Ted',
'Monday Bill',
'Monday John',
'Wednesday George']);