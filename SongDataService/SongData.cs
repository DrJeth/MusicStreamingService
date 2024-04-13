using MusicStreamingModel;
using System.Collections.Generic;
using System;

namespace SongDataService
{
    public class SongData
    {

        public string? words;
        List<Song> songs = new List<Song>();

        public SongData()
        {
 
            Song BestMusic1Song = new Song
            {
                SongTitle = "Flowers",
                Artist = "Miley Cyrus",
                Composer = "Miley Cyrus, Gregory “Aldae” Hein, and Michael Pollack",
                Duration = TimeSpan.FromMinutes(3.20),
                ReleaseDate = new DateTime(1 / 13 / 2023),
                HashTag = "#InTheMusicTopPlaylist"
            };
            Song BestMusic2Song = new Song
            {
                SongTitle = "Vampire",
                Artist = "Olivia Rodrigo",
                Composer = "Olivia Rodrigo and co-wrote the song with its producer Dan Nigro",
                Duration = TimeSpan.FromMinutes(3.39),
                ReleaseDate = new DateTime(5 / 30 / 2023),
                HashTag = "#InTheMusicTopPlaylist"
            };
            Song BestMusic3Song = new Song
            {
                SongTitle = "As It Was",
                Artist = "Harry Styles",
                Composer = "Harry Styles, Kid Harpoon and Tyler Johnson",
                Duration = TimeSpan.FromMinutes(3.39),
                ReleaseDate = new DateTime(5 / 30 / 2023),
                HashTag = "#InTheMusicTopPlaylist"
            };
            Song BestMusic4Song = new Song
            {
                SongTitle = "All Too Well",
                Artist = "Taylor Swift",
                Composer = "Taylor Swift",
                Duration = TimeSpan.FromMinutes(5.29),
                ReleaseDate = new DateTime(10 / 22 / 2012),
                HashTag = "#InTheMusicTopPlaylist"
            };
            Song BestMusic5Song = new Song
            {
                SongTitle = "Perfect",
                Artist = "Ed Sheeran",
                Composer = "Ed Sheeran",
                Duration = TimeSpan.FromMinutes(4.23),
                ReleaseDate = new DateTime(3 / 3 / 2017),
                HashTag = "#InTheMusicTopPlaylist"
            };
            Song BestMusic6Song = new Song
            {
                SongTitle = "How Long",
                Artist = "Charlie Puth",
                Composer = "Charlie Puth",
                Duration = TimeSpan.FromMinutes(3.18),
                ReleaseDate = new DateTime(10 / 5 / 2017),
                HashTag = "#InTheMusicTopPlaylist"
            };
            Song BestMusic7Song = new Song
            {
                SongTitle = "Viva La Vida",
                Artist = "Coldplay",
                Composer = "Coldplay",
                Duration = TimeSpan.FromMinutes(4.03),
                ReleaseDate = new DateTime(5 / 25 / 2008),
                HashTag = "#InTheMusicTopPlaylist"
            };
            Song BestMusic8Song = new Song
            {
                SongTitle = "Just Dance",
                Artist = "Lady Gaga",
                Composer = "Lady Gaga and Akon",
                Duration = TimeSpan.FromMinutes(4.01),
                ReleaseDate = new DateTime(4 / 8 / 2008),
                HashTag = "#InTheMusicTopPlaylist"
            };
            Song BestMusic9Song = new Song
            {
                SongTitle = "Sanctuary",
                Artist = "Joji",
                Composer = "Joji,Daniel Wilson, Justin Raisen, and Luke Niccoli",
                Duration = TimeSpan.FromMinutes(3.00),
                ReleaseDate = new DateTime(6 / 14 / 2019),
                HashTag = "#InTheMusicTopPlaylist"
            };
            Song BestMusic10Song = new Song
            {
                SongTitle = "Until I Found You",
                Artist = "Stephen Sanchez",
                Composer = "Stephen Sanchez",
                Duration = TimeSpan.FromMinutes(2.57),
                ReleaseDate = new DateTime(9 / 1 / 2021),
                HashTag = "#InTheMusicTopPlaylist"
            };

            songs.Add(BestMusic1Song);
            songs.Add(BestMusic2Song);
            songs.Add(BestMusic3Song);
            songs.Add(BestMusic4Song);
            songs.Add(BestMusic5Song);
            songs.Add(BestMusic6Song);
            songs.Add(BestMusic7Song);
            songs.Add(BestMusic8Song);
            songs.Add(BestMusic9Song);
            songs.Remove(BestMusic10Song);
        }
        public void AddSong(Song sound)
        {
            songs.Add(sound);
        }
        public void RemoveSong(Song sound)
        {
            songs.Remove(sound);
        }
        public List<Song> GetSongList()
        {
            return songs;
        }
    }
}
