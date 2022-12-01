namespace MusicPlayer
{
    internal class MusicPlayer
    {
        List<Songs> SongList { get; set; } = new();
        List<Songs> Playlist { get; set; } = new();
        PriorityQueue<Songs, int> Queue { get; set; } = new();

        public void AddASong(Songs song)
        {
            SongList.Add(song);
        }
        public void RemoveASong(Songs song)
        {
            Songs s = SongList.FirstOrDefault(a => a.SongName == song.SongName);
            if (s != null)
            {
                SongList.Remove(s);
                Playlist.Remove(s);

            }
        }

        public void DisplayAllSongs()
        {

            foreach (Songs song in SongList)
            {

                Console.WriteLine($"Song: {song.SongName} Artist: {song.Artist}");
            }

        }

        public void CreateAPlaylist(Songs song)
        {
            Songs s = SongList.FirstOrDefault(a => a.SongName == song.SongName);
            if (s != null)
            {
                Playlist.Add(s);

            }
        }
        public void viewPlaylist()
        {
            foreach (Songs song in Playlist)
            {
                Console.WriteLine($"Song: {song.SongName} Artist: {song.Artist}");
            }
        }

        public void RemoveSongFromPlayList(Songs song)
        {
            Songs s = Playlist.FirstOrDefault(a => a.SongName == song.SongName);
            if (s != null)
            {
                Playlist.Remove(s);
            }
        }

        public void PlaySongsInTheExactOrder()
        {
            LoopThrough();
        }

        public void PlaySongsInAlphabeticalOrder()
        {

            SongList.Sort((a, b) => a.SongName.CompareTo(b.SongName));
            LoopThrough();
        }

        public void ShuffleSongs()
        {
            SongList = SongList.OrderBy(i => Guid.NewGuid()).ToList();
            LoopThrough();
        }
        public void PlayListInTheExactOrder()
        {
            LoopThroughPlayList();
        }
        public void PlayListInAlphabeticalOrder()
        {
            Playlist.Sort((a, b) => a.SongName.CompareTo(b.SongName));
            LoopThroughPlayList();
        }
        public void ShufflePlayList()
        {
            Playlist = Playlist.OrderBy(i => Guid.NewGuid()).ToList();
            LoopThroughPlayList();
        }
        public void GetNextSong(Songs songs)
        {
            int index = 0;
            int count = 0;
           // Songs s = SongList.FirstOrDefault(a => a.SongName == songs.SongName);
           foreach(Songs song in SongList)
            {
                Queue.Enqueue(songs, count);
                count++;
            }

            



        }

        public void LoopThrough()
        {
            foreach (Songs song in SongList)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("-|");
                }
                Console.WriteLine($"\nJamming: {song.SongName} by {song.Artist}");
                Thread.Sleep(1000);
            }
        }

        public void LoopThroughPlayList()
        {
            foreach (Songs song in Playlist)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("-|");
                }
                Console.WriteLine($"\nJamming: {song.SongName} by {song.Artist}");
                Thread.Sleep(1000);
            }
        }

    }


}

