function solve(movies) {
    let moviesInfo = [];

    const addMovieCommand = "addMovie ";
    const directedBy = " directedBy ";
    const onDate = " onDate ";

    for (let line of movies) {
        if (line.includes(addMovieCommand)) {
            moviesInfo.push({ name: line.substring(addMovieCommand.length) });
        } else if (line.includes(directedBy)) {
            let [name, directorName] = line.split(directedBy);
            let movie = moviesInfo.find(element => element.name == name);
            if (movie) {
                movie.director = directorName;                
            }
        } else if (line.includes(onDate)) {
            let [name, date] = line.split(onDate);
            let movie = moviesInfo.find(element => element.name == name);
            if (movie) {
                movie.date = date;         
            }
        }        
    }

    moviesInfo
    .filter(movie => movie.director && movie.date)
    .forEach(movie => console.log(JSON.stringify(movie)));
}
 
solve([
    'addMovie The Avengers',
    'addMovie Superman',
    'The Avengers directedBy Anthony Russo',
    'The Avengers onDate 30.07.2010',
    'Captain America onDate 30.07.2010',
    'Captain America directedBy Joe Russo'
    ]  
);