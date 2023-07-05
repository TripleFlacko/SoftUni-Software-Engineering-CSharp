using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        int numberOfSongs = int.Parse(Console.ReadLine());

        List<Song> allSongs = new List<Song>();

        for (int i = 0; i < numberOfSongs; i++)
        {
            AddInfoToSongList(allSongs);
        }
        string typeList = Console.ReadLine();
        PrintTheFilteredSongs(allSongs, typeList);
    }

    private static void PrintTheFilteredSongs(List<Song> allSongs, string typeList)
    {
        if (typeList == "all")
        {
            foreach (Song song in allSongs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (Song song in allSongs)
            {
                if (typeList == song.TypeList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    private static void AddInfoToSongList(List<Song> allSongs)
    {
        List<string> list = Console.ReadLine().Split('_').ToList();

        string type = list[0];
        string name = list[1];
        string time = list[2];

        Song song = new Song(type, name, time);
        allSongs.Add(song);
    }
}
class Song
{
    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}