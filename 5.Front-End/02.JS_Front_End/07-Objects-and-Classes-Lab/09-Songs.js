function solve(input) {
    let songs = [];

    class Song {
        constructor(typeList, name, time) {
            this.typeList = typeList;
            this.name = name;
            this.time = time;
        }
    }

    let numberOfSongs = input.shift();
    let typeSong = input.pop();

    for (let index = 0; index < numberOfSongs; index++) {        
        let [typeList, name, time] = input[index].split('_');

        let song = new Song(typeList, name, time);
        songs.push(song);
    }

    if (typeSong === 'all') {
        songs.forEach(song => console.log(song.name));
    } else {
        songs.filter(song => song.typeList === typeSong).forEach(song => console.log(song.name));
    }
}
 
solve([4,
    'favourite_DownTown_3:14',
    'listenLater_Andalouse_3:24',
    'favourite_In To The Night_3:58',
    'favourite_Live It Up_3:48',
    'listenLater']
    );