using MusicStreamingModel;
using SongDataService;

namespace MusicLibraryBL
{
    public class MusicAlbum
    {
        SongData dataService = new SongData();

        public Song GetSongByArtist(string songArtist)
        {
            Song foundSong = null;
            foreach(Song song in dataService.GetSongList())
            {
                if (song.Artist == songArtist)
                {
                    foundSong = song;
                }
            };
            return foundSong;
        }
    }
}