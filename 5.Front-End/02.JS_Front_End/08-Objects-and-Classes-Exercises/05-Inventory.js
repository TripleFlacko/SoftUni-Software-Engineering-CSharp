function solve(input) {
    let heroes = [];
    input.forEach(hero => {
        let [name, level, items] = hero.split(' / ');
        heroes.push({
            name,
            level: Number(level),
            items
        })
    })
    
    heroes.sort((a, b) => a.level - b.level);

    for (const hero of heroes) {
        console.log(`Hero: ${hero.name}`);        
        console.log(`level => ${hero.level}`);        
        console.log(`items => ${hero.items}`);        
    }
}
 
solve([
    'Batman / 2 / Banana, Gun',
    'Superman / 18 / Sword',
    'Poppy / 28 / Sentinel, Antara'
    ]    
    );