namespace MusicPlayer
{
    internal class Application
    {
        MusicPlayer musicPlayer = new MusicPlayer();
        public void Menu()
        {
            do
            {
                Console.WriteLine("This is your music player\nPlease select an Option\n1. General playlist\n2. Create a new playlist.\n3. Exit");
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            GeneralPlayList();
                            break;
                        case 2:
                            Console.Clear();
                            NewPlayList();
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch
                {
                    Console.WriteLine("Invalid");
                }
            } while (true);
        }
        

        public Songs GetSong()
        {
            Console.WriteLine("Song name: ");
            string songName = Console.ReadLine();
            Console.WriteLine("Artist");
            string artist = Console.ReadLine();
            Songs songToAdd = new(songName, artist);
            return songToAdd;
        }
        private void NewPlayList()
        {
            do
            {
                try
                {
                    Console.WriteLine("Please select an option\n1. Create A Playlist\n2. View Playlist\n3. Remove a song from playlist\n4. Play songs in Exact Order\n5. Play songs in alphabetical order\n6. Shuffle Playlist\n7. Return\n8. Exit");
                    
                    int userInput = Convert.ToInt32(Console.ReadLine());


                    switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Name your playlist");
                            string playlistName = Console.ReadLine();
                            Songs addSongToPlaylist = GetSong();
                            musicPlayer.CreateAPlaylist(addSongToPlaylist);
                            break;

                        case 2:
                            Console.Clear();
                            musicPlayer.viewPlaylist();
                            break;
                        case 3:
                            Console.Clear();
                            Songs removeSongFromPlaylist = GetSong();
                            musicPlayer.RemoveSongFromPlayList(removeSongFromPlaylist);
                            break;
                        case 4:
                            Console.Clear();
                            musicPlayer.PlayListInTheExactOrder();
                            break;
                        case 5:
                            Console.Clear();
                            musicPlayer.PlaySongsInAlphabeticalOrder();
                            break;
                        case 6:
                            Console.Clear();
                            musicPlayer.ShufflePlayList();
                            break;
                        case 7:
                            return;
                        case 0:
                            LogOut();
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }

                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch
                {
                    Console.WriteLine("Invalid");
                }
            } while (true);
        }

        private void GeneralPlayList()
        {
            
            do
            {

                Console.WriteLine("Please select an option\n1. Add a song\n2. Remove a song\n3. Display all songs\n4. Play songs in the exact order\n5. Play songs in alphabetical order\n6. Shuffle songs\n7. Return\n0. Exit");
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());


                    switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            Songs songToAdd = GetSong();
                            musicPlayer.AddASong(songToAdd);

                            break;
                        case 2:
                            Console.Clear();
                            Songs songToRemove = GetSong();
                            musicPlayer.RemoveASong(songToRemove);
                            break;
                        case 3:
                            Console.Clear();
                            musicPlayer.DisplayAllSongs();
                            break;
                        case 4:
                            Console.Clear();
                            musicPlayer.PlaySongsInTheExactOrder();
                            break;
                        case 5:
                            Console.Clear();
                            musicPlayer.PlaySongsInAlphabeticalOrder();
                            break;
                        case 6:
                            Console.Clear();
                            musicPlayer.ShuffleSongs();
                            break;
                        case 7:
                            return;
                        case 0:
                            LogOut();
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                }catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch
                {
                    Console.WriteLine("Invalid");
                }

            } while (true);
        }
        public void LogOut()
        {
            Environment.Exit(0);
        }

    }


}

